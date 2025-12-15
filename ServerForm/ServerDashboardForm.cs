using Google.Cloud.Firestore;
using QuizShared.Models;
using ServerForm.Services;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ServerForm.Forms
{
    public partial class ServerDashboardForm : Form
    {
        private readonly RoomManager _roomManager = new RoomManager();
        private readonly QuizManager _quizManager = new QuizManager();
        private readonly QuizRepository _quizRepo = new QuizRepository();

        private FirestoreChangeListener _listener;
        private Room _room;

        public ServerDashboardForm()
        {
            InitializeComponent();
        }

        private async void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string title = txtRoomTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Tên phòng (Room Title) không được để trống.\n\n" +
                    "Vui lòng nhập tên phòng trước khi tạo room.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtRoomTitle.Focus();
                return;
            }

            var allQuiz = await _quizRepo.GetAllQuizAsync();

            if (allQuiz.Count == 0)
            {
                MessageBox.Show("Chưa có quiz nào. Hãy tạo quiz trước.");
                return;
            }

            var selectForm = new QuizSelectForm(allQuiz);
            if (selectForm.ShowDialog() != DialogResult.OK)
                return;

            string selectedQuizId = selectForm.SelectedQuizId;
            var selectedQuiz = allQuiz
    .FirstOrDefault(q => q.QuizId == selectedQuizId);
            if (selectedQuiz == null ||
    string.IsNullOrWhiteSpace(selectedQuiz.Title))
            {
                MessageBox.Show("Quiz được chọn không có tên hợp lệ!");
                return;
            }
            string host = "HOST";

            string roomId = await _roomManager.CreateRoomAsync(host, title, selectedQuizId);
            lblRoomId.Text = $"Room ID: {roomId}";

            ListenRoom(roomId);
        }

        private void ListenRoom(string roomId)
        {
            StopListener();

            var roomRef = FirestoreService.Db.Collection("rooms").Document(roomId);

            _listener = roomRef.Listen(snapshot =>
            {
                if (snapshot == null || !snapshot.Exists)
                    return;

                _room = snapshot.ConvertTo<Room>();
                Invoke(new Action(UpdateUI));
            });
        }
        private void ResetDashboardUI()
        {
            lblState.Text = "State: -";
            lblCurrent.Text = "Câu: -";
            lblRoomId.Text = "Room ID: -";

            lstPlayers.Items.Clear();
            ClearCurrentQuestion();

            btnStart.Enabled = false;
            btnNext.Enabled = false;
            btnCheck.Enabled = false;
            btnFinish.Enabled = false;

        }

        private void UpdateUI()
        {
            if (_room == null) return;

            lstPlayers.Items.Clear();

            foreach (var p in _room.Players.Values)
                lstPlayers.Items.Add($"{p.Name} - {p.Score}");

            lblState.Text = $"State: {_room.State}";
            lblCurrent.Text = $"Câu: {_room.CurrentQuestionIndex + 1}";

            if (_room.Questions != null)
            {
                btnNext.Enabled = _room.CurrentQuestionIndex < _room.Questions.Count - 1;
            }
            else
            {
                btnNext.Enabled = false;
            }
            UpdateCurrentQuestion();
        }
        private void UpdateCurrentQuestion()
        {
            if (_room == null || _room.Questions == null)
            {
                ClearCurrentQuestion();
                return;
            }

            int index = _room.CurrentQuestionIndex;

            if (index < 0 || index >= _room.Questions.Count)
            {
                ClearCurrentQuestion();
                return;
            }

            var q = _room.Questions[index];

            txtCurQuestion.Text = q.Text;
            txtCurA.Text = "A. " + q.Options["A"];
            txtCurB.Text = "B. " + q.Options["B"];
            txtCurC.Text = "C. " + q.Options["C"];
            txtCurD.Text = "D. " + q.Options["D"];
        }

        private void ClearCurrentQuestion()
        {
            txtCurQuestion.Clear();
            txtCurA.Clear();
            txtCurB.Clear();
            txtCurC.Clear();
            txtCurD.Clear();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_room != null)
                await _quizManager.StartQuizAsync(_room.RoomId);
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_room == null) return;

            int next = _room.CurrentQuestionIndex + 1;
            await _quizManager.NextQuestionAsync(_room.RoomId, next);
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            if (_room == null) return;

            await _quizManager.FinishQuizAsync(_room.RoomId);

            btnStart.Enabled = false;
            btnNext.Enabled = false;
            btnFinish.Enabled = false;
            btnCheck.Enabled = false;
            txtRoomTitle.Enabled = false;
            var finishedRoom = _room;
            await _quizManager.FinishQuizAsync(_room.RoomId);

            ResetDashboardUI();

            using (var result = new ServerResultForm(_room))
            {
                result.ShowDialog();
            }
        }
        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (_room != null)
                await _quizManager.ShowResultAsync(_room.RoomId);
        }
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            new QuizEditorForm().ShowDialog();
        }

        private void StopListener()
        {
            if (_listener != null)
            {
                _listener.StopAsync(CancellationToken.None)
                         .GetAwaiter()
                         .GetResult();
                _listener = null;
            }
        }
    }
}

using ClientForm.Services;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace ClientForm.Forms
{
    public partial class QuizPlayForm : Form
    {
        private readonly string _uid;
        private readonly string _roomId;
        private readonly string _email;

        private readonly RoomService _roomService = new RoomService();
        private readonly QuizService _quizService = new QuizService();

        private Room _room;
        private List<Question> _questions = new List<Question>();

        private Timer _timer;
        private int _timeLeft;
        private int _lastQuestionIndex = -1;

        public QuizPlayForm(string roomId, string uid, string email)
        {
            InitializeComponent();
            _roomId = roomId;
            _uid = uid;
            _email = email;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;

            _roomService.ListenRoom(roomId, OnRoomUpdate);
        }

        private async void OnRoomUpdate(Room room)
        {
            if (room == null)
                return;

            _room = room;

            if (_questions.Count == 0 && !string.IsNullOrWhiteSpace(room.QuizId))
            {
                var temp = await _quizService.LoadQuestionsAsync(room.QuizId);
                _questions = temp ?? new List<Question>();
            }

            if (!IsDisposed && IsHandleCreated)
            {
                try { Invoke(new Action(RefreshUI)); }
                catch { }
            }
        }

        private void RefreshUI()
        {
            if (_room == null)
                return;

            lblState.Text = _room.State.ToString();
            lblIndex.Text = "Câu: " + (_room.CurrentQuestionIndex + 1);


            if (_questions.Count == 0)
            {
                lblQ.Text = "Đang tải câu hỏi...";
                return;
            }

            if (_room.State == QuizState.InQuestion)
            {
                if (_room.CurrentQuestionIndex >= 0 &&
                    _room.CurrentQuestionIndex < _questions.Count)
                {
                    var q = _questions[_room.CurrentQuestionIndex];

                    lblQ.Text = q.Text;
                    btnA.Text = q.Options.ContainsKey("A") ? q.Options["A"] : "";
                    btnB.Text = q.Options.ContainsKey("B") ? q.Options["B"] : "";
                    btnC.Text = q.Options.ContainsKey("C") ? q.Options["C"] : "";
                    btnD.Text = q.Options.ContainsKey("D") ? q.Options["D"] : "";

                    EnableAnswerButtons();

                    if (_lastQuestionIndex != _room.CurrentQuestionIndex)
                    {
                        _lastQuestionIndex = _room.CurrentQuestionIndex;

                        ResetButtonVisual();
                        ActiveControl = null;
                        lblResult.Text = "";
                        _timeLeft = q.TimeLimitSeconds;
                        lblTime.Text = "Time: " + _timeLeft;
                        _timer.Stop();
                        _timer.Start();
                    }
                }
                else
                {
                    lblQ.Text = "";
                }
            }
            else
            {
                _timer.Stop();
                DisableAnswerButtons();
            }

            if (_room.State == QuizState.ShowingResult &&
                _room.CurrentQuestionIndex == _lastQuestionIndex)
            {
                ShowResultIcon();
            }

            if (_room.Players != null && _room.Players.ContainsKey(_uid))
            {
                lblScore.Text = "Điểm: " + _room.Players[_uid].Score;
            }
            if (_room.State == QuizState.Finished)
            {
                using (var result = new ResultForm(_room, _uid, _email))
                {
                    Hide();
                    result.ShowDialog();
                    Close();
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTime.Text = "Time: " + _timeLeft;

            if (_timeLeft <= 0)
            {
                _timer.Stop();
                DisableAnswerButtons();
            }
        }

        private async void Answer_Click(object sender, EventArgs e)
        {
            if (_room == null || _room.State != QuizState.InQuestion)
                return;

            if (!(sender is Button btn) || btn.Tag == null)
                return;

            string ans = btn.Tag.ToString();

            await _quizService.SubmitAnswerAsync(_roomId, _uid, ans);
            lblResult.Text = "Bạn chọn: " + ans;
        }
        private void DisableAnswerButtons()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void EnableAnswerButtons()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }
        private void ResetButtonVisual()
        {
            btnA.Text = btnA.Text.Split('✔', '✖')[0].Trim();
            btnB.Text = btnB.Text.Split('✔', '✖')[0].Trim();
            btnC.Text = btnC.Text.Split('✔', '✖')[0].Trim();
            btnD.Text = btnD.Text.Split('✔', '✖')[0].Trim();

            btnA.ForeColor = Color.Black;
            btnB.ForeColor = Color.Black;
            btnC.ForeColor = Color.Black;
            btnD.ForeColor = Color.Black;

            btnA.BackColor = SystemColors.Control;
            btnB.BackColor = SystemColors.Control;
            btnC.BackColor = SystemColors.Control;
            btnD.BackColor = SystemColors.Control;

            btnA.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnB.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnC.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnD.FlatAppearance.BorderColor = SystemColors.ControlDark;
        }

        private void ShowResultIcon()
        {
            if (_room == null || !_room.Players.ContainsKey(_uid))
                return;

            var q = _questions[_room.CurrentQuestionIndex];
            string correct = q.CorrectAnswer;
            string selected = _room.Players[_uid].SelectedAnswer;

            ApplyIcon(btnA, "A", selected, correct);
            ApplyIcon(btnB, "B", selected, correct);
            ApplyIcon(btnC, "C", selected, correct);
            ApplyIcon(btnD, "D", selected, correct);
        }

        private void ApplyIcon(Button btn, string key, string selected, string correct)
        {
            if (key == correct)
            {
                btn.Text += " ✔";
                btn.ForeColor = Color.Green;
                btn.BackColor = Color.LightGreen;
                btn.FlatAppearance.BorderColor = Color.Green;
            }
            else if (key == selected)
            {
                btn.Text += " ✖";
                btn.ForeColor = Color.Red;
                btn.BackColor = Color.LightCoral;
                btn.FlatAppearance.BorderColor = Color.Red;
            }
        }

    }
}

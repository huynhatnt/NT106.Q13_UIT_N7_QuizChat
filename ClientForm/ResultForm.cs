using QuizShared.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class ResultForm : Form
    {
        private readonly string _uid;
        private readonly string _email;

        public ResultForm(Room room, string uid, string email)
        {
            InitializeComponent();

            _uid = uid;
            _email = email;

            if (room == null || room.Players == null)
                return;

            var players = room.Players.Values
                .OrderByDescending(p => p.Score)
                .ToList();

            lvLeaderboard.Items.Clear();

            int myRank = -1;
            int total = players.Count;

            int rank = 0;
            int lastScore = -1;

            for (int i = 0; i < players.Count; i++)
            {
                var p = players[i];

                if (p.Score != lastScore)
                {
                    rank++;
                    lastScore = p.Score;
                }

                var item = new ListViewItem(rank.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Score.ToString());

                if (rank == 1)
                {
                    item.BackColor = Color.Gold;
                    item.Font = new Font(item.Font, FontStyle.Bold);
                    item.SubItems[0].Text = "🥇 1";
                }
                else if (rank == 2)
                {
                    item.BackColor = Color.Silver;
                    item.Font = new Font(item.Font, FontStyle.Bold);
                    item.SubItems[0].Text = "🥈 2";
                }
                else if (rank == 3)
                {
                    item.BackColor = Color.Peru;
                    item.Font = new Font(item.Font, FontStyle.Bold);
                    item.SubItems[0].Text = "🥉 3";
                }

                if (p.Uid == uid)
                {
                    myRank = rank;
                    item.Font = new Font(item.Font, FontStyle.Bold);
                }

                lvLeaderboard.Items.Add(item);
            }

            var me = players.FirstOrDefault(p => p.Uid == uid);
            if (me != null)
            {
                lblYourScore.Text = $"Điểm của bạn: {me.Score}";
                lblYourRank.Text = $"Bạn xếp hạng: {myRank}/{total}";
            }
        }

        private void btnBackToRoomList_Click(object sender, EventArgs e)
        {
            var roomList = new RoomListForm(_uid, _email);
            roomList.Show();
            Close();
        }
    }
}

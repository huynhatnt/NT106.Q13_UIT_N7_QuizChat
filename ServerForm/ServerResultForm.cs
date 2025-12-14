using QuizShared.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ServerForm.Services;

namespace ServerForm.Forms
{
    public partial class ServerResultForm : Form
    {
        private readonly Room _room;
        private readonly RoomManager _roomManager = new RoomManager();

        public ServerResultForm(Room room)
        {
            InitializeComponent();
            _room = room;

            if (_room == null || _room.Players == null)
                return;

            var players = _room.Players.Values
                .OrderByDescending(p => p.Score)
                .ToList();

            int rank = 0;
            int lastScore = -1;

            foreach (var p in players)
            {
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
                    item.Text = "🥇 1";
                    item.BackColor = Color.Gold;
                }
                else if (rank == 2)
                {
                    item.Text = "🥈 2";
                    item.BackColor = Color.Silver;
                }
                else if (rank == 3)
                {
                    item.Text = "🥉 3";
                    item.BackColor = Color.Peru;
                }

                lvPlayers.Items.Add(item);
            }
        }

        private async void btnCloseRoom_Click(object sender, EventArgs e)
        {
            if (_room != null)
            {
                await _roomManager.DeleteRoomAsync(_room.RoomId);
                Close();
            }
        }
    }
}

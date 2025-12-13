using ClientForm.Services;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class RoomListForm : Form
    {
        private readonly string _uid;
        private readonly string _email;

        private readonly RoomService _roomService = new RoomService();
        private List<Room> _rooms = new List<Room>();

        public RoomListForm(string uid, string email)
        {
            InitializeComponent();
            _uid = uid;
            _email = email;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 🔥 Lắng nghe realtime danh sách phòng
            _roomService.ListenRooms(UpdateRoomList);
        }

        private void UpdateRoomList(List<Room> rooms)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateRoomList(rooms)));
                return;
            }

            _rooms = rooms;
            lstRooms.Items.Clear();

            foreach (Room r in _rooms)
            {
                lstRooms.Items.Add($"{r.RoomId} - {r.Title}");
            }
        }

        private async void btnJoin_Click(object sender, EventArgs e)
        {
            if (lstRooms.SelectedIndex < 0) return;

            Room room = _rooms[lstRooms.SelectedIndex];

            Player p = new Player
            {
                Uid = _uid,
                Name = _email,
                Score = 0
            };

            await _roomService.JoinRoomAsync(room.RoomId, p);

            QuizPlayForm form = new QuizPlayForm(room.RoomId, _uid);
            this.Hide();
            form.Show();
        }
    }
}

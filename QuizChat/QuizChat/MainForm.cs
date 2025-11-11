using QuizChat;
using System;
using System.Windows.Forms;

namespace QuizChatApp
{
    public partial class MainForm : Form
    {
        private readonly string _username;

        public MainForm() : this(null) { }

        public MainForm(string username)
        {
            _username = username ?? "Người dùng";
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby(this.Location, this.Size);
            lobby.Show();
            this.Close();
        }
    }
}

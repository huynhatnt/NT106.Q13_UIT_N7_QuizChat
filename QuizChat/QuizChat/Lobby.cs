using QuizChatApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizChat
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            FirebaseHelper.InitializeFirebase();
        }
        public Lobby(Point location, Size size) : this()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            TutorialForm tutorialForm = new TutorialForm(this.Location, this.Size);
            tutorialForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this.Location, this.Size);
            loginForm.Show();
            this.Hide();
        }
    }
}

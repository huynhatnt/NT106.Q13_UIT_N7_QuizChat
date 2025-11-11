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
    public partial class TutorialForm : Form
    {
        public TutorialForm(Point location, Size size) : this()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }
        public TutorialForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby(this.Location, this.Size);
            lobby.Show();
            this.Hide();
        }
    }
}

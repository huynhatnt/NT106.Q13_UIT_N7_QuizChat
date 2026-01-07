using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace QuizLauncher
{
    public partial class QuizLauncherForm : Form
    {
        public QuizLauncherForm()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"..\..\..\ServerForm\bin\Debug\ServerForm.exe"
            );
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"..\..\..\ClientForm\bin\Debug\ClientForm.exe"
            );
        }
    }
}

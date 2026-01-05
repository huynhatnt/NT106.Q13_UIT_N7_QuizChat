using ClientForm.Services;
using System;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<string, string> res =
                    await _auth.LoginAsync(txtEmail.Text.Trim(), txtPass.Text.Trim());

                string uid = res.Item1;
                string email = res.Item2;

                RoomListForm f = new RoomListForm(uid, email);
                this.Hide();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                string msg = "Đăng nhập thất bại.";

                if (ex.Message.Contains("EMAIL_NOT_FOUND"))
                {
                    msg = "Email chưa được đăng ký.";
                    icon = MessageBoxIcon.Warning;
                }
                else if (ex.Message.Contains("INVALID_PASSWORD") ||
                         ex.Message.Contains("INVALID_LOGIN_CREDENTIALS"))
                {
                    msg = "Mật khẩu không đúng.";
                    icon = MessageBoxIcon.Warning;
                }
                else if (ex.Message.Contains("API key not valid"))
                {
                    msg = "Hệ thống xác thực chưa được cấu hình đúng.";
                    icon = MessageBoxIcon.Error;
                }

                MessageBox.Show(
                    msg,
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    icon
                );
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            new ForgotPasswordForm().ShowDialog();
        }
    }
}

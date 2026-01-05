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
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ email và mật khẩu.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                Tuple<string, string> res =
                    await _auth.LoginAsync(txtEmail.Text.Trim(), txtPass.Text.Trim());

                string uid = res.Item1;
                string mail = res.Item2;

                RoomListForm f = new RoomListForm(uid, mail);
                this.Hide();
                f.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("INVALID_EMAIL"))
                {
                    MessageBox.Show(
                        "Email chưa được đăng ký.",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else if (ex.Message.Contains("INVALID_PASSWORD") ||
                         ex.Message.Contains("INVALID_LOGIN_CREDENTIALS"))
                {
                    MessageBox.Show(
                        "Mật khẩu không đúng.",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không thể đăng nhập. Vui lòng thử lại sau.",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm f = new RegisterForm();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();

            ForgotPasswordForm f = new ForgotPasswordForm();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
        }
    }
}

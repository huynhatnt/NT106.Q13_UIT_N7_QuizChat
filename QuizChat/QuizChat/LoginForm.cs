using QuizChat;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizChatApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Point location, Size size) : this()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await HandleLoginAsync();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await HandleRegisterAsync();
        }

        private async Task HandleLoginAsync()
        {
            SetUiEnabled(false);
            try
            {
                string userNameInput = txtUserName?.Text?.Trim();
                string emailOrUser = txtEmail?.Text?.Trim();
                string password = txtPassword?.Text ?? string.Empty;

                if (string.IsNullOrEmpty(emailOrUser) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản, email và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = await FirebaseHelper.LoginUserAsync(emailOrUser, password);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage ?? "Đăng nhập thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string displayName = result.Username;
                if (string.IsNullOrEmpty(displayName))
                {
                    if (!string.IsNullOrEmpty(userNameInput))
                        displayName = userNameInput;
                    else
                        displayName = result.Email ?? "Người dùng";
                }

                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var main = new MainForm(displayName)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location,
                    Size = this.Size
                };
                main.Show();

                this.Hide();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUiEnabled(true);
            }
        }

        private async Task HandleRegisterAsync()
        {
            SetUiEnabled(false);
            try
            {
                string username = txtUserName?.Text?.Trim();
                string email = txtEmail?.Text?.Trim();
                string password = txtPassword?.Text ?? string.Empty;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản, email và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = await FirebaseHelper.RegisterUserAsync(username, email, password);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage ?? "Đăng ký thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUiEnabled(true);
            }
        }

        private void SetUiEnabled(bool enabled)
        {
            if (txtUserName != null) txtUserName.Enabled = enabled;
            if (txtEmail != null) txtEmail.Enabled = enabled;
            if (txtPassword != null) txtPassword.Enabled = enabled;
            if (btnLogin != null) btnLogin.Enabled = enabled;
            if (btnRegister != null) btnRegister.Enabled = enabled;
            Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby(this.Location, this.Size);
            lobby.Show();
            this.Hide();
        }
    }
}
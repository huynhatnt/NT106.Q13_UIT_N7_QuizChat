using ClientForm.Services;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ClientForm.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _auth = new AuthService();
        private readonly UserService _user = new UserService();

        private string _generatedOtp;
        private DateTime _otpCreatedTime;

        public RegisterForm()
        {
            InitializeComponent();
        }
        private void btnOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            try
            {
                _generatedOtp = new Random().Next(100000, 999999).ToString();
                _otpCreatedTime = DateTime.Now;

                OTPEmailService.SendOtp(email, _generatedOtp);

                MessageBox.Show(
                    $"OTP đã được gửi tới {email}",
                    "Gửi OTP thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Không thể gửi OTP.\nVui lòng kiểm tra kết nối mạng hoặc thử lại sau.",
                    "Gửi OTP thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPass.Text;
                string confirm = txtConfirmPass.Text;
                string otp = txtOTP.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirm) ||
                    string.IsNullOrWhiteSpace(otp))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                if (password != confirm)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.");
                    return;
                }

                if (_generatedOtp == null)
                {
                    MessageBox.Show("Vui lòng gửi OTP trước.");
                    return;
                }

                if (DateTime.Now > _otpCreatedTime.AddMinutes(5))
                {
                    MessageBox.Show("OTP đã hết hạn. Vui lòng gửi lại.");
                    return;
                }

                if (otp != _generatedOtp)
                {
                    MessageBox.Show("OTP không đúng.");
                    return;
                }

                string uid = await _auth.RegisterAsync(email, password);
                await _user.SaveUserAsync(uid, email);

                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                string msg = "Đăng ký thất bại.";
                MessageBoxIcon icon = MessageBoxIcon.Error;

                if (ex.Message.Contains("EMAIL_EXISTS"))
                {
                    msg = "Email đã được đăng ký.";
                    icon = MessageBoxIcon.Warning;
                }
                else if (ex.Message.Contains("WEAK_PASSWORD"))
                {
                    msg = "Mật khẩu quá yếu.";
                    icon = MessageBoxIcon.Warning;
                }

                MessageBox.Show(msg, "Lỗi đăng ký", MessageBoxButtons.OK, icon);
            }
        }
        void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;
            txt.Tag = placeholder;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtEmail, "email@example.com");
            SetPlaceholder(txtPass, "Password");
            SetPlaceholder(txtOTP, "Nhập OTP");
            SetPlaceholder(txtConfirmPass, "Confirm Password");
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null || txt.Tag == null) return;

            if (txt.Text == txt.Tag.ToString())
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;

                if (txt == txtPass || txt == txtConfirmPass)
                    txt.UseSystemPasswordChar = true;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (!(sender is TextBox txt))
                return;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt.Tag is string placeholder)
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;

                    if (txt == txtPass || txt == txtConfirmPass)
                        txt.UseSystemPasswordChar = false;
                }
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

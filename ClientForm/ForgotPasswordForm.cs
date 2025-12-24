using ClientForm.Services;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClientForm
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        private string _generatedOtp;
        private DateTime _otpCreatedTime;
        private int _otpAttempts;

        private const int OTP_TTL_MINUTES = 5;
        private const int OTP_MAX_ATTEMPTS = 5;

        private Timer _otpTimer;
        private int _otpRemainingSeconds;

        public ForgotPasswordForm()
        {
            InitializeComponent();

            btnOTP.Click += btnOTP_Click;
            btnForgot.Click += btnForgot_Click;

            _otpTimer = new Timer();
            _otpTimer.Interval = 1000;
            _otpTimer.Tick += OtpTimer_Tick;
        }

        private string GenerateNumericOtp(int digits = 6)
        {
            if (digits <= 0) digits = 6;

            int max = (int)Math.Pow(10, digits);
            byte[] bytes = new byte[4];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            int value = Math.Abs(BitConverter.ToInt32(bytes, 0)) % max;
            return value.ToString($"D{digits}");
        }

        private async void btnOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email == txtEmail.Tag?.ToString())
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            try
            {
                bool exists = await _auth.IsEmailExistsAsync(email);
                if (!exists)
                {
                    MessageBox.Show("Email này chưa được đăng ký.");
                    return;
                }

                _generatedOtp = GenerateNumericOtp();
                _otpCreatedTime = DateTime.UtcNow;
                _otpAttempts = 0;

                await Task.Run(() =>
                    OtpEmailService.SendOtp(email, _generatedOtp)
                );

                _otpRemainingSeconds = OTP_TTL_MINUTES * 60;
                btnOTP.Enabled = false;
                UpdateOtpCountdown();
                _otpTimer.Start();

                MessageBox.Show(
                    "OTP đã được gửi về email.\n" +
                    $"OTP có hiệu lực trong {OTP_TTL_MINUTES} phút."
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi OTP: " + ex.Message);
            }
        }

        private async void btnForgot_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string otp = txtOTP.Text.Trim();

            if (email == txtEmail.Tag?.ToString() ||
                otp == txtOTP.Tag?.ToString())
            {
                MessageBox.Show("Vui lòng nhập email và OTP.");
                return;
            }

            if (_generatedOtp == null)
            {
                MessageBox.Show("Vui lòng gửi OTP trước.");
                return;
            }

            if (DateTime.UtcNow > _otpCreatedTime.AddMinutes(OTP_TTL_MINUTES))
            {
                ResetOtpState();
                MessageBox.Show("OTP đã hết hạn. Vui lòng gửi lại.");
                return;
            }

            _otpAttempts++;
            if (_otpAttempts > OTP_MAX_ATTEMPTS)
            {
                ResetOtpState();
                MessageBox.Show("Bạn đã nhập OTP sai quá nhiều lần. Vui lòng gửi lại.");
                return;
            }

            if (otp != _generatedOtp)
            {
                MessageBox.Show("OTP không đúng.");
                return;
            }

            try
            {
                await _auth.SendResetPasswordEmailAsync(email);

                ResetOtpState();

                MessageBox.Show(
                    "Xác thực OTP thành công.\n" +
                    "Email đặt lại mật khẩu đã được gửi.\n" +
                    "Vui lòng kiểm tra hộp thư của bạn."
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email reset mật khẩu: " + ex.Message);
            }
        }


        private void OtpTimer_Tick(object sender, EventArgs e)
        {
            _otpRemainingSeconds--;

            if (_otpRemainingSeconds <= 0)
            {
                ResetOtpState();
                lblOtpCountdown.Text = "OTP đã hết hạn.";
                return;
            }

            UpdateOtpCountdown();
        }

        private void UpdateOtpCountdown()
        {
            int min = _otpRemainingSeconds / 60;
            int sec = _otpRemainingSeconds % 60;
            lblOtpCountdown.Text = $"OTP còn hiệu lực: {min:D2}:{sec:D2}";
        }

        private void ResetOtpState()
        {
            _otpTimer.Stop();
            _generatedOtp = null;
            btnOTP.Enabled = true;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            //lblOtpCountdown.Text = "OTP còn hiệu lực: --:--";
        }


    }
}

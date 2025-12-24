using System.Net;
using System.Net.Mail;

namespace ClientForm.Services
{
    public static class OTPEmailService
    {
        public static void SendOtp(string toEmail, string otp)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("24521706@gm.uit.edu.vn");
            mail.To.Add(toEmail);
            mail.Subject = "Mã OTP xác nhận";
            mail.Body = $"Mã OTP của bạn là: {otp}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(
                "24521706@gm.uit.edu.vn",
                "kfmnqfpwqtjqcqcv"
            );
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}

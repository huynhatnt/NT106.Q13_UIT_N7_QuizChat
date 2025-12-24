namespace ClientForm
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpForgot = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOTP = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnOTP = new System.Windows.Forms.Button();
            this.lblOtpCountdown = new System.Windows.Forms.Label();
            this.btnForgot = new System.Windows.Forms.Button();
            this.grpForgot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(126, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUÊN MẬT KHẨU";
            // 
            // grpForgot
            // 
            this.grpForgot.Controls.Add(this.lblEmail);
            this.grpForgot.Controls.Add(this.txtEmail);
            this.grpForgot.Controls.Add(this.lblOTP);
            this.grpForgot.Controls.Add(this.txtOTP);
            this.grpForgot.Controls.Add(this.btnOTP);
            this.grpForgot.Controls.Add(this.lblOtpCountdown);
            this.grpForgot.Controls.Add(this.btnForgot);
            this.grpForgot.Location = new System.Drawing.Point(20, 50);
            this.grpForgot.Name = "grpForgot";
            this.grpForgot.Size = new System.Drawing.Size(380, 230);
            this.grpForgot.TabIndex = 1;
            this.grpForgot.TabStop = false;
            this.grpForgot.Text = "Xác thực OTP";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.Location = new System.Drawing.Point(29, 84);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(31, 17);
            this.lblOTP.TabIndex = 2;
            this.lblOTP.Text = "OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(84, 81);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(166, 24);
            this.txtOTP.TabIndex = 3;
            // 
            // btnOTP
            // 
            this.btnOTP.Location = new System.Drawing.Point(260, 79);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(90, 28);
            this.btnOTP.TabIndex = 4;
            this.btnOTP.Text = "Gửi OTP";
            // 
            // lblOtpCountdown
            // 
            this.lblOtpCountdown.AutoSize = true;
            this.lblOtpCountdown.Location = new System.Drawing.Point(120, 110);
            this.lblOtpCountdown.Name = "lblOtpCountdown";
            this.lblOtpCountdown.Size = new System.Drawing.Size(0, 17);
            this.lblOtpCountdown.TabIndex = 5;
            this.lblOtpCountdown.Visible = false;
            // 
            // btnForgot
            // 
            this.btnForgot.Location = new System.Drawing.Point(120, 155);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(160, 36);
            this.btnForgot.TabIndex = 6;
            this.btnForgot.Text = "Xác nhận";
            // 
            // ForgotPasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 304);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpForgot);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.grpForgot.ResumeLayout(false);
            this.grpForgot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpForgot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.Label lblOtpCountdown;
        private System.Windows.Forms.Button btnForgot;
    }
}

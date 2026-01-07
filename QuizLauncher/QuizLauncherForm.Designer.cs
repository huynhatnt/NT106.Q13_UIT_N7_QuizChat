namespace QuizLauncher
{
    partial class QuizLauncherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnOpenServer;
        private System.Windows.Forms.Button btnOpenClient;
        private System.Windows.Forms.Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.btnOpenClient = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblSubTitle);
            this.panelMain.Controls.Add(this.btnOpenServer);
            this.panelMain.Controls.Add(this.btnOpenClient);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(479, 396);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(145, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎮 QUIZ SYSTEM";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(145, 64);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(178, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Chọn chế độ bạn muốn mở";
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenServer.Location = new System.Drawing.Point(91, 129);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(289, 83);
            this.btnOpenServer.TabIndex = 2;
            this.btnOpenServer.Text = "🖥️  MỞ SERVER";
            this.btnOpenServer.UseVisualStyleBackColor = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // btnOpenClient
            // 
            this.btnOpenClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenClient.Location = new System.Drawing.Point(91, 252);
            this.btnOpenClient.Name = "btnOpenClient";
            this.btnOpenClient.Size = new System.Drawing.Size(289, 83);
            this.btnOpenClient.TabIndex = 3;
            this.btnOpenClient.Text = "👤  MỞ CLIENT";
            this.btnOpenClient.UseVisualStyleBackColor = true;
            this.btnOpenClient.Click += new System.EventHandler(this.btnOpenClient_Click);
            // 
            // QuizLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(479, 396);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Launcher";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

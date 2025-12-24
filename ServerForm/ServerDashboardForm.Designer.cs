namespace ServerForm.Forms
{
    partial class ServerDashboardForm
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
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.lblRoomTitle = new System.Windows.Forms.Label();
            this.txtRoomTitle = new System.Windows.Forms.TextBox();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.txtCurC = new System.Windows.Forms.TextBox();
            this.txtCurB = new System.Windows.Forms.TextBox();
            this.txtCurD = new System.Windows.Forms.TextBox();
            this.txtCurA = new System.Windows.Forms.TextBox();
            this.txtCurQuestion = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpRoom.SuspendLayout();
            this.grpState.SuspendLayout();
            this.grpPlayers.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BẢNG ĐIỀU KHIỂN SERVER\r\n";
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.lblRoomTitle);
            this.grpRoom.Controls.Add(this.txtRoomTitle);
            this.grpRoom.Controls.Add(this.btnCreateRoom);
            this.grpRoom.Controls.Add(this.btnCreateQuiz);
            this.grpRoom.Controls.Add(this.lblRoomId);
            this.grpRoom.Location = new System.Drawing.Point(20, 53);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(600, 110);
            this.grpRoom.TabIndex = 1;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Room";
            // 
            // lblRoomTitle
            // 
            this.lblRoomTitle.AutoSize = true;
            this.lblRoomTitle.Location = new System.Drawing.Point(15, 30);
            this.lblRoomTitle.Name = "lblRoomTitle";
            this.lblRoomTitle.Size = new System.Drawing.Size(51, 17);
            this.lblRoomTitle.TabIndex = 0;
            this.lblRoomTitle.Text = "Tiêu đề";
            // 
            // txtRoomTitle
            // 
            this.txtRoomTitle.Location = new System.Drawing.Point(90, 27);
            this.txtRoomTitle.Name = "txtRoomTitle";
            this.txtRoomTitle.Size = new System.Drawing.Size(300, 24);
            this.txtRoomTitle.TabIndex = 1;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(410, 25);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(160, 30);
            this.btnCreateRoom.TabIndex = 2;
            this.btnCreateRoom.Text = "Tạo phòng";
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.Location = new System.Drawing.Point(410, 60);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(160, 30);
            this.btnCreateQuiz.TabIndex = 3;
            this.btnCreateQuiz.Text = "Tạo Quiz\r\n";
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(15, 70);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(73, 17);
            this.lblRoomId.TabIndex = 4;
            this.lblRoomId.Text = "ID Phòng: -";
            // 
            // grpState
            // 
            this.grpState.Controls.Add(this.lblState);
            this.grpState.Controls.Add(this.lblCurrent);
            this.grpState.Location = new System.Drawing.Point(20, 173);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(300, 80);
            this.grpState.TabIndex = 2;
            this.grpState.TabStop = false;
            this.grpState.Text = "Quiz State";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(15, 30);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(78, 17);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Trạng thái: -";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(15, 55);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(42, 17);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Câu: -";
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.lstPlayers);
            this.grpPlayers.Location = new System.Drawing.Point(330, 173);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(290, 220);
            this.grpPlayers.TabIndex = 3;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Players";
            // 
            // lstPlayers
            // 
            this.lstPlayers.ItemHeight = 17;
            this.lstPlayers.Location = new System.Drawing.Point(15, 25);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(260, 174);
            this.lstPlayers.TabIndex = 0;
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnStart);
            this.grpControl.Controls.Add(this.btnNext);
            this.grpControl.Controls.Add(this.btnCheck);
            this.grpControl.Controls.Add(this.btnFinish);
            this.grpControl.Location = new System.Drawing.Point(20, 263);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(300, 130);
            this.grpControl.TabIndex = 4;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Control";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(160, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Câu tiếp";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(20, 75);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 35);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(160, 75);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(120, 35);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Hoàn thành";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.txtCurC);
            this.grpQuestion.Controls.Add(this.txtCurB);
            this.grpQuestion.Controls.Add(this.txtCurD);
            this.grpQuestion.Controls.Add(this.txtCurA);
            this.grpQuestion.Controls.Add(this.txtCurQuestion);
            this.grpQuestion.Location = new System.Drawing.Point(20, 399);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(600, 109);
            this.grpQuestion.TabIndex = 5;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Question";
            // 
            // txtCurC
            // 
            this.txtCurC.Location = new System.Drawing.Point(307, 64);
            this.txtCurC.Multiline = true;
            this.txtCurC.Name = "txtCurC";
            this.txtCurC.ReadOnly = true;
            this.txtCurC.Size = new System.Drawing.Size(135, 30);
            this.txtCurC.TabIndex = 4;
            // 
            // txtCurB
            // 
            this.txtCurB.Location = new System.Drawing.Point(163, 64);
            this.txtCurB.Multiline = true;
            this.txtCurB.Name = "txtCurB";
            this.txtCurB.ReadOnly = true;
            this.txtCurB.Size = new System.Drawing.Size(135, 30);
            this.txtCurB.TabIndex = 3;
            // 
            // txtCurD
            // 
            this.txtCurD.Location = new System.Drawing.Point(451, 64);
            this.txtCurD.Multiline = true;
            this.txtCurD.Name = "txtCurD";
            this.txtCurD.ReadOnly = true;
            this.txtCurD.Size = new System.Drawing.Size(135, 30);
            this.txtCurD.TabIndex = 2;
            // 
            // txtCurA
            // 
            this.txtCurA.Location = new System.Drawing.Point(18, 64);
            this.txtCurA.Multiline = true;
            this.txtCurA.Name = "txtCurA";
            this.txtCurA.ReadOnly = true;
            this.txtCurA.Size = new System.Drawing.Size(135, 30);
            this.txtCurA.TabIndex = 1;
            // 
            // txtCurQuestion
            // 
            this.txtCurQuestion.Location = new System.Drawing.Point(20, 23);
            this.txtCurQuestion.Multiline = true;
            this.txtCurQuestion.Name = "txtCurQuestion";
            this.txtCurQuestion.ReadOnly = true;
            this.txtCurQuestion.Size = new System.Drawing.Size(565, 30);
            this.txtCurQuestion.TabIndex = 0;
            // 
            // ServerDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.grpControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ServerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Dashboard";
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.grpState.ResumeLayout(false);
            this.grpState.PerformLayout();
            this.grpPlayers.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.Label lblRoomTitle;
        private System.Windows.Forms.TextBox txtRoomTitle;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Label lblRoomId;

        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCurrent;

        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.ListBox lstPlayers;

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.TextBox txtCurC;
        private System.Windows.Forms.TextBox txtCurB;
        private System.Windows.Forms.TextBox txtCurD;
        private System.Windows.Forms.TextBox txtCurA;
        private System.Windows.Forms.TextBox txtCurQuestion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

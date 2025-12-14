namespace ServerForm.Forms
{
    partial class ServerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRoomTitle = new System.Windows.Forms.TextBox();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room Title:";
            // 
            // txtRoomTitle
            // 
            this.txtRoomTitle.Location = new System.Drawing.Point(100, 17);
            this.txtRoomTitle.Name = "txtRoomTitle";
            this.txtRoomTitle.Size = new System.Drawing.Size(220, 20);
            this.txtRoomTitle.TabIndex = 1;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCreateRoom.Location = new System.Drawing.Point(330, 15);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(110, 25);
            this.btnCreateRoom.TabIndex = 2;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(20, 60);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(58, 13);
            this.lblRoomId.TabIndex = 3;
            this.lblRoomId.Text = "Room ID: -";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(20, 90);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State: -";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(20, 120);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(35, 13);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "Câu: -";
            // 
            // lstPlayers
            // 
            this.lstPlayers.Location = new System.Drawing.Point(20, 160);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(420, 199);
            this.lstPlayers.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnStart.Location = new System.Drawing.Point(20, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 30);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNext.Location = new System.Drawing.Point(120, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 30);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFinish.Location = new System.Drawing.Point(220, 380);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(90, 30);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCreateQuiz.Location = new System.Drawing.Point(330, 60);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(110, 30);
            this.btnCreateQuiz.TabIndex = 10;
            this.btnCreateQuiz.Text = "Create Quiz";
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCheck.Location = new System.Drawing.Point(322, 380);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 30);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ServerDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(460, 440);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRoomTitle);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCreateQuiz);
            this.Name = "ServerDashboardForm";
            this.Text = "Server Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRoomTitle;
        private System.Windows.Forms.Button btnCreateRoom;

        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCurrent;

        private System.Windows.Forms.ListBox lstPlayers;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinish;

        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnCheck;
    }
}

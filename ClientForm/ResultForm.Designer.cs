namespace ClientForm.Forms
{
    partial class ResultForm
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
            this.grpLeaderboard = new System.Windows.Forms.GroupBox();
            this.lvLeaderboard = new System.Windows.Forms.ListView();
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblYourRank = new System.Windows.Forms.Label();
            this.btnBackToRoomList = new System.Windows.Forms.Button();
            this.grpLeaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(170, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KẾT QUẢ QUIZ";
            // 
            // grpLeaderboard
            // 
            this.grpLeaderboard.Controls.Add(this.lvLeaderboard);
            this.grpLeaderboard.Location = new System.Drawing.Point(20, 50);
            this.grpLeaderboard.Name = "grpLeaderboard";
            this.grpLeaderboard.Size = new System.Drawing.Size(440, 270);
            this.grpLeaderboard.TabIndex = 1;
            this.grpLeaderboard.TabStop = false;
            this.grpLeaderboard.Text = "Bảng xếp hạng";
            // 
            // lvLeaderboard
            // 
            this.lvLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRank,
            this.colName,
            this.colScore});
            this.lvLeaderboard.FullRowSelect = true;
            this.lvLeaderboard.GridLines = true;
            this.lvLeaderboard.HideSelection = false;
            this.lvLeaderboard.Location = new System.Drawing.Point(15, 25);
            this.lvLeaderboard.Name = "lvLeaderboard";
            this.lvLeaderboard.Size = new System.Drawing.Size(410, 230);
            this.lvLeaderboard.TabIndex = 0;
            this.lvLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvLeaderboard.View = System.Windows.Forms.View.Details;
            // 
            // colRank
            // 
            this.colRank.Text = "Hạng";
            this.colRank.Width = 70;
            // 
            // colName
            // 
            this.colName.Text = "Người chơi";
            this.colName.Width = 260;
            // 
            // colScore
            // 
            this.colScore.Text = "Điểm";
            this.colScore.Width = 80;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Location = new System.Drawing.Point(20, 342);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(91, 17);
            this.lblYourScore.TabIndex = 2;
            this.lblYourScore.Text = "Điểm của bạn:";
            // 
            // lblYourRank
            // 
            this.lblYourRank.AutoSize = true;
            this.lblYourRank.Location = new System.Drawing.Point(20, 367);
            this.lblYourRank.Name = "lblYourRank";
            this.lblYourRank.Size = new System.Drawing.Size(90, 17);
            this.lblYourRank.TabIndex = 3;
            this.lblYourRank.Text = "Bạn xếp hạng:";
            // 
            // btnBackToRoomList
            // 
            this.btnBackToRoomList.Location = new System.Drawing.Point(260, 345);
            this.btnBackToRoomList.Name = "btnBackToRoomList";
            this.btnBackToRoomList.Size = new System.Drawing.Size(180, 36);
            this.btnBackToRoomList.TabIndex = 4;
            this.btnBackToRoomList.Text = "Quay lại danh sách phòng";
            this.btnBackToRoomList.Click += new System.EventHandler(this.btnBackToRoomList_Click);
            // 
            // ResultForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 417);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpLeaderboard);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblYourRank);
            this.Controls.Add(this.btnBackToRoomList);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.grpLeaderboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpLeaderboard;
        private System.Windows.Forms.ListView lvLeaderboard;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;

        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblYourRank;

        private System.Windows.Forms.Button btnBackToRoomList;
    }
}

namespace ClientForm.Forms
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblYourRank;
        private System.Windows.Forms.ListView lvLeaderboard;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.Button btnBackToRoomList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblYourRank = new System.Windows.Forms.Label();
            this.lvLeaderboard = new System.Windows.Forms.ListView();
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackToRoomList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(415, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KẾT QUẢ QUIZ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblYourScore.Location = new System.Drawing.Point(10, 48);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(108, 20);
            this.lblYourScore.TabIndex = 1;
            this.lblYourScore.Text = "Điểm của bạn:";
            // 
            // lblYourRank
            // 
            this.lblYourRank.AutoSize = true;
            this.lblYourRank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYourRank.Location = new System.Drawing.Point(272, 48);
            this.lblYourRank.Name = "lblYourRank";
            this.lblYourRank.Size = new System.Drawing.Size(104, 19);
            this.lblYourRank.TabIndex = 4;
            this.lblYourRank.Text = "Bạn xếp hạng:";
            // 
            // lvLeaderboard
            // 
            this.lvLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRank,
            this.colName,
            this.colScore});
            this.lvLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLeaderboard.FullRowSelect = true;
            this.lvLeaderboard.GridLines = true;
            this.lvLeaderboard.HideSelection = false;
            this.lvLeaderboard.Location = new System.Drawing.Point(10, 74);
            this.lvLeaderboard.MultiSelect = false;
            this.lvLeaderboard.Name = "lvLeaderboard";
            this.lvLeaderboard.Size = new System.Drawing.Size(395, 191);
            this.lvLeaderboard.TabIndex = 2;
            this.lvLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvLeaderboard.View = System.Windows.Forms.View.Details;
            // 
            // colRank
            // 
            this.colRank.Text = "Hạng";
            // 
            // colName
            // 
            this.colName.Text = "Tên";
            this.colName.Width = 245;
            // 
            // colScore
            // 
            this.colScore.Text = "Điểm";
            this.colScore.Width = 85;
            // 
            // btnBackToRoomList
            // 
            this.btnBackToRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToRoomList.Location = new System.Drawing.Point(276, 273);
            this.btnBackToRoomList.Name = "btnBackToRoomList";
            this.btnBackToRoomList.Size = new System.Drawing.Size(129, 39);
            this.btnBackToRoomList.TabIndex = 3;
            this.btnBackToRoomList.Text = "Về danh sách phòng";
            this.btnBackToRoomList.UseVisualStyleBackColor = true;
            this.btnBackToRoomList.Click += new System.EventHandler(this.btnBackToRoomList_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 322);
            this.Controls.Add(this.btnBackToRoomList);
            this.Controls.Add(this.lvLeaderboard);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblYourRank);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

namespace ServerForm.Forms
{
    partial class ServerResultForm
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
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lvPlayers = new System.Windows.Forms.ListView();
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseRoom = new System.Windows.Forms.Button();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(160, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KẾT QUẢ QUIZ";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lvPlayers);
            this.grpResult.Location = new System.Drawing.Point(20, 55);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(440, 280);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Scoreboard";
            // 
            // lvPlayers
            // 
            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRank,
            this.colName,
            this.colScore});
            this.lvPlayers.FullRowSelect = true;
            this.lvPlayers.GridLines = true;
            this.lvPlayers.HideSelection = false;
            this.lvPlayers.Location = new System.Drawing.Point(15, 25);
            this.lvPlayers.Name = "lvPlayers";
            this.lvPlayers.Size = new System.Drawing.Size(410, 240);
            this.lvPlayers.TabIndex = 0;
            this.lvPlayers.UseCompatibleStateImageBehavior = false;
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            // 
            // colRank
            // 
            this.colRank.Text = "Rank";
            this.colRank.Width = 80;
            // 
            // colName
            // 
            this.colName.Text = "Player";
            this.colName.Width = 246;
            // 
            // colScore
            // 
            this.colScore.Text = "Score";
            this.colScore.Width = 80;
            // 
            // btnCloseRoom
            // 
            this.btnCloseRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCloseRoom.ForeColor = System.Drawing.Color.White;
            this.btnCloseRoom.Location = new System.Drawing.Point(160, 350);
            this.btnCloseRoom.Name = "btnCloseRoom";
            this.btnCloseRoom.Size = new System.Drawing.Size(160, 38);
            this.btnCloseRoom.TabIndex = 2;
            this.btnCloseRoom.Text = "🔒 ĐÓNG PHÒNG";
            this.btnCloseRoom.UseVisualStyleBackColor = false;
            this.btnCloseRoom.Click += new System.EventHandler(this.btnCloseRoom_Click);
            // 
            // ServerResultForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnCloseRoom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ServerResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz Result";
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.ListView lvPlayers;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;

        private System.Windows.Forms.Button btnCloseRoom;
    }
}

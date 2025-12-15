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
            this.colRank = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colScore = new System.Windows.Forms.ColumnHeader();

            this.btnCloseRoom = new System.Windows.Forms.Button();

            this.grpResult.SuspendLayout();
            this.SuspendLayout();

            /* ===== FORM ===== */
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz Result";

            /* ===== TITLE ===== */
            this.lblTitle.Text = "QUIZ RESULT";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(160, 15);

            /* ===== GROUP RESULT ===== */
            this.grpResult.Text = "Scoreboard";
            this.grpResult.Location = new System.Drawing.Point(20, 55);
            this.grpResult.Size = new System.Drawing.Size(440, 280);

            /* ===== LIST VIEW ===== */
            this.lvPlayers.Location = new System.Drawing.Point(15, 25);
            this.lvPlayers.Size = new System.Drawing.Size(410, 240);
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            this.lvPlayers.FullRowSelect = true;
            this.lvPlayers.GridLines = true;
            this.lvPlayers.HideSelection = false;

            this.colRank.Text = "Rank";
            this.colRank.Width = 80;

            this.colName.Text = "Player";
            this.colName.Width = 226;

            this.colScore.Text = "Score";
            this.colScore.Width = 100;

            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.colRank,
                this.colName,
                this.colScore
            });

            this.grpResult.Controls.Add(this.lvPlayers);

            /* ===== CLOSE ROOM ===== */
            this.btnCloseRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseRoom.ForeColor = System.Drawing.Color.White;
            this.btnCloseRoom.Text = "🔒 ĐÓNG PHÒNG";
            this.btnCloseRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCloseRoom.Size = new System.Drawing.Size(160, 38);
            this.btnCloseRoom.Location = new System.Drawing.Point(160, 350);
            this.btnCloseRoom.Click += new System.EventHandler(this.btnCloseRoom_Click);

            /* ===== ADD CONTROLS ===== */
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnCloseRoom);

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

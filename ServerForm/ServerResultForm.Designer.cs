namespace ServerForm.Forms
{
    partial class ServerResultForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView lvPlayers;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.Button btnCloseRoom;

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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lvPlayers = new System.Windows.Forms.ListView();
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏁 KẾT QUẢ CUỐI CÙNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.Location = new System.Drawing.Point(0, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.lblTotal.Size = new System.Drawing.Size(700, 30);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng số người chơi: 0";
            // 
            // lvPlayers
            // 
            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRank,
            this.colName,
            this.colScore});
            this.lvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlayers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvPlayers.FullRowSelect = true;
            this.lvPlayers.GridLines = true;
            this.lvPlayers.HideSelection = false;
            this.lvPlayers.Location = new System.Drawing.Point(0, 80);
            this.lvPlayers.Name = "lvPlayers";
            this.lvPlayers.Size = new System.Drawing.Size(700, 370);
            this.lvPlayers.TabIndex = 2;
            this.lvPlayers.UseCompatibleStateImageBehavior = false;
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            // 
            // colRank
            // 
            this.colRank.Text = "Hạng";
            this.colRank.Width = 80;
            // 
            // colName
            // 
            this.colName.Text = "Người chơi";
            this.colName.Width = 420;
            // 
            // colScore
            // 
            this.colScore.Text = "Điểm";
            this.colScore.Width = 120;
            // 
            // btnCloseRoom
            // 
            this.btnCloseRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCloseRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRoom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCloseRoom.ForeColor = System.Drawing.Color.White;
            this.btnCloseRoom.Location = new System.Drawing.Point(0, 450);
            this.btnCloseRoom.Name = "btnCloseRoom";
            this.btnCloseRoom.Size = new System.Drawing.Size(700, 50);
            this.btnCloseRoom.TabIndex = 3;
            this.btnCloseRoom.Text = "🔒 ĐÓNG PHÒNG";
            this.btnCloseRoom.UseVisualStyleBackColor = false;
            this.btnCloseRoom.Click += new System.EventHandler(this.btnCloseRoom_Click);
            // 
            // ServerResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lvPlayers);
            this.Controls.Add(this.btnCloseRoom);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ServerResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả Quiz";
            this.ResumeLayout(false);

        }
    }
}

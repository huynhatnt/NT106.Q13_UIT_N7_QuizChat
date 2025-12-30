namespace ClientForm.Forms
{
    partial class RoomListForm
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

            this.grpRooms = new System.Windows.Forms.GroupBox();
            this.lstRooms = new System.Windows.Forms.ListBox();

            this.btnJoin = new System.Windows.Forms.Button();

            this.grpRooms.SuspendLayout();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room List";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(140, 12);
            this.lblTitle.Text = "PHÒNG CHƠI";

            this.grpRooms.Location = new System.Drawing.Point(20, 50);
            this.grpRooms.Size = new System.Drawing.Size(380, 230);
            this.grpRooms.Text = "Danh sách phòng";

            this.lstRooms.Location = new System.Drawing.Point(15, 25);
            this.lstRooms.Size = new System.Drawing.Size(350, 190);

            this.grpRooms.Controls.Add(this.lstRooms);

            this.btnJoin.Size = new System.Drawing.Size(160, 36);
            this.btnJoin.Location = new System.Drawing.Point(130, 300);
            this.btnJoin.Text = "Tham gia phòng";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpRooms);
            this.Controls.Add(this.btnJoin);

            this.grpRooms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpRooms;
        private System.Windows.Forms.ListBox lstRooms;

        private System.Windows.Forms.Button btnJoin;
    }
}

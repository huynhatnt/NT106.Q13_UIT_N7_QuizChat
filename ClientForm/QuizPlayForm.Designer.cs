namespace ClientForm.Forms
{
    partial class QuizPlayForm
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
            this.lblState = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(38, 13);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(84, 20);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Trạng thái:";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(38, 42);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(90, 20);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "Câu: (none)";
            // 
            // lblQ
            // 
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQ.Location = new System.Drawing.Point(38, 78);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(446, 69);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Câu hỏi sẽ hiển thị ở đây";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Control;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(42, 166);
            this.btnA.Name = "btnA";
            this.btnA.Padding = new System.Windows.Forms.Padding(12, 0, 45, 0);
            this.btnA.Size = new System.Drawing.Size(280, 60);
            this.btnA.TabIndex = 3;
            this.btnA.Tag = "A";
            this.btnA.Text = "Đáp án A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnB
            // 
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(353, 166);
            this.btnB.Name = "btnB";
            this.btnB.Padding = new System.Windows.Forms.Padding(12, 0, 45, 0);
            this.btnB.Size = new System.Drawing.Size(280, 60);
            this.btnB.TabIndex = 4;
            this.btnB.Tag = "B";
            this.btnB.Text = "Đáp án B";
            this.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(42, 239);
            this.btnC.Name = "btnC";
            this.btnC.Padding = new System.Windows.Forms.Padding(12, 0, 45, 0);
            this.btnC.Size = new System.Drawing.Size(280, 60);
            this.btnC.TabIndex = 5;
            this.btnC.Tag = "C";
            this.btnC.Text = "Đáp án C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnD
            // 
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(353, 239);
            this.btnD.Name = "btnD";
            this.btnD.Padding = new System.Windows.Forms.Padding(12, 0, 45, 0);
            this.btnD.Size = new System.Drawing.Size(280, 60);
            this.btnD.TabIndex = 6;
            this.btnD.Tag = "D";
            this.btnD.Text = "Đáp án D";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(38, 317);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(444, 26);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Kết quả:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(455, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 20);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Điểm:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(455, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 20);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Thời gian:";
            // 
            // QuizPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 364);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
    }
}

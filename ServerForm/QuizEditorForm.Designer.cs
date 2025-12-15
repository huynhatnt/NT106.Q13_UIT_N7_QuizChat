namespace ServerForm.Forms
{
    partial class QuizEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpQuiz = new System.Windows.Forms.GroupBox();
            this.lblQuizTitle = new System.Windows.Forms.Label();
            this.txtQuizTitle = new System.Windows.Forms.TextBox();
            this.grpEditor = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.cboCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnSaveQuiz = new System.Windows.Forms.Button();
            this.grpQuiz.SuspendLayout();
            this.grpEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.grpList.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz Editor";
            // 
            // grpQuiz
            // 
            this.grpQuiz.Controls.Add(this.lblQuizTitle);
            this.grpQuiz.Controls.Add(this.txtQuizTitle);
            this.grpQuiz.Location = new System.Drawing.Point(20, 45);
            this.grpQuiz.Name = "grpQuiz";
            this.grpQuiz.Size = new System.Drawing.Size(520, 65);
            this.grpQuiz.TabIndex = 1;
            this.grpQuiz.TabStop = false;
            this.grpQuiz.Text = "Quiz";
            // 
            // lblQuizTitle
            // 
            this.lblQuizTitle.AutoSize = true;
            this.lblQuizTitle.Location = new System.Drawing.Point(15, 30);
            this.lblQuizTitle.Name = "lblQuizTitle";
            this.lblQuizTitle.Size = new System.Drawing.Size(32, 17);
            this.lblQuizTitle.TabIndex = 0;
            this.lblQuizTitle.Text = "Title";
            // 
            // txtQuizTitle
            // 
            this.txtQuizTitle.Location = new System.Drawing.Point(70, 27);
            this.txtQuizTitle.Name = "txtQuizTitle";
            this.txtQuizTitle.Size = new System.Drawing.Size(430, 24);
            this.txtQuizTitle.TabIndex = 1;
            // 
            // grpEditor
            // 
            this.grpEditor.Controls.Add(this.lblQuestion);
            this.grpEditor.Controls.Add(this.txtQuestion);
            this.grpEditor.Controls.Add(this.lblA);
            this.grpEditor.Controls.Add(this.txtA);
            this.grpEditor.Controls.Add(this.lblB);
            this.grpEditor.Controls.Add(this.txtB);
            this.grpEditor.Controls.Add(this.lblC);
            this.grpEditor.Controls.Add(this.txtC);
            this.grpEditor.Controls.Add(this.lblD);
            this.grpEditor.Controls.Add(this.txtD);
            this.grpEditor.Controls.Add(this.lblCorrect);
            this.grpEditor.Controls.Add(this.cboCorrectAnswer);
            this.grpEditor.Controls.Add(this.lblTime);
            this.grpEditor.Controls.Add(this.numTime);
            this.grpEditor.Controls.Add(this.btnAddQuestion);
            this.grpEditor.Location = new System.Drawing.Point(20, 115);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(520, 260);
            this.grpEditor.TabIndex = 2;
            this.grpEditor.TabStop = false;
            this.grpEditor.Text = "Add Question";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(15, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 23);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(90, 27);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(410, 24);
            this.txtQuestion.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(15, 65);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(69, 23);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(90, 62);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(410, 24);
            this.txtA.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(15, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(69, 23);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(90, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(410, 24);
            this.txtB.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.Location = new System.Drawing.Point(15, 135);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(69, 23);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(90, 132);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(410, 24);
            this.txtC.TabIndex = 7;
            // 
            // lblD
            // 
            this.lblD.Location = new System.Drawing.Point(15, 170);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(69, 23);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(90, 167);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(410, 24);
            this.txtD.TabIndex = 9;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Location = new System.Drawing.Point(15, 205);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(69, 23);
            this.lblCorrect.TabIndex = 10;
            this.lblCorrect.Text = "Correct";
            // 
            // cboCorrectAnswer
            // 
            this.cboCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorrectAnswer.Location = new System.Drawing.Point(90, 202);
            this.cboCorrectAnswer.Name = "cboCorrectAnswer";
            this.cboCorrectAnswer.Size = new System.Drawing.Size(70, 25);
            this.cboCorrectAnswer.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(190, 205);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 23);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(240, 202);
            this.numTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(120, 24);
            this.numTime.TabIndex = 13;
            this.numTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(390, 200);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(110, 30);
            this.btnAddQuestion.TabIndex = 14;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lstQuestions);
            this.grpList.Controls.Add(this.btnDelete);
            this.grpList.Location = new System.Drawing.Point(20, 380);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(300, 170);
            this.grpList.TabIndex = 3;
            this.grpList.TabStop = false;
            this.grpList.Text = "Questions";
            // 
            // lstQuestions
            // 
            this.lstQuestions.ItemHeight = 17;
            this.lstQuestions.Location = new System.Drawing.Point(10, 25);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(280, 106);
            this.lstQuestions.TabIndex = 0;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            this.lstQuestions.DoubleClick += new System.EventHandler(this.lstQuestions_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.txtPreview);
            this.grpPreview.Location = new System.Drawing.Point(330, 380);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(210, 170);
            this.grpPreview.TabIndex = 4;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(10, 25);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(190, 130);
            this.txtPreview.TabIndex = 0;
            // 
            // btnSaveQuiz
            // 
            this.btnSaveQuiz.Enabled = false;
            this.btnSaveQuiz.Location = new System.Drawing.Point(210, 575);
            this.btnSaveQuiz.Name = "btnSaveQuiz";
            this.btnSaveQuiz.Size = new System.Drawing.Size(140, 40);
            this.btnSaveQuiz.TabIndex = 5;
            this.btnSaveQuiz.Text = "Save Quiz";
            this.btnSaveQuiz.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // QuizEditorForm
            // 
            this.ClientSize = new System.Drawing.Size(560, 640);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpQuiz);
            this.Controls.Add(this.grpEditor);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.btnSaveQuiz);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "QuizEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Editor";
            this.grpQuiz.ResumeLayout(false);
            this.grpQuiz.PerformLayout();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpQuiz;
        private System.Windows.Forms.Label lblQuizTitle;
        private System.Windows.Forms.TextBox txtQuizTitle;

        private System.Windows.Forms.GroupBox grpEditor;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox cboCorrectAnswer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Button btnAddQuestion;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.TextBox txtPreview;

        private System.Windows.Forms.Button btnSaveQuiz;
    }
}

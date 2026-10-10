namespace StudentGradeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            label1 = new Label();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblMath = new Label();
            nudMath = new NumericUpDown();
            lblEnglish = new Label();
            nudEnglish = new NumericUpDown();
            lblScience = new Label();
            nudScience = new NumericUpDown();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudMath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(411, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(286, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Grade Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(173, 98);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(91, 23);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "Student ID";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(173, 124);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(318, 30);
            txtStudentId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 166);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 3;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(583, 98);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(87, 23);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Full Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(583, 124);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(295, 30);
            txtStudentName.TabIndex = 5;
            // 
            // lblMath
            // 
            lblMath.AutoSize = true;
            lblMath.Location = new Point(173, 166);
            lblMath.Name = "lblMath";
            lblMath.Size = new Size(97, 23);
            lblMath.TabIndex = 6;
            lblMath.Text = "Math Score";
            // 
            // nudMath
            // 
            nudMath.Location = new Point(173, 192);
            nudMath.Name = "nudMath";
            nudMath.Size = new Size(318, 30);
            nudMath.TabIndex = 7;
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(583, 166);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(111, 23);
            lblEnglish.TabIndex = 8;
            lblEnglish.Text = "English Score";
            // 
            // nudEnglish
            // 
            nudEnglish.Location = new Point(582, 192);
            nudEnglish.Name = "nudEnglish";
            nudEnglish.Size = new Size(296, 30);
            nudEnglish.TabIndex = 9;
            // 
            // lblScience
            // 
            lblScience.AutoSize = true;
            lblScience.Location = new Point(173, 236);
            lblScience.Name = "lblScience";
            lblScience.Size = new Size(114, 23);
            lblScience.TabIndex = 10;
            lblScience.Text = "Science Score";
            // 
            // nudScience
            // 
            nudScience.Location = new Point(173, 262);
            nudScience.Name = "nudScience";
            nudScience.Size = new Size(318, 30);
            nudScience.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(216, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 33);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(395, 327);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 33);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 33);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(767, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 33);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.InactiveCaption;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(145, 367);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(810, 303);
            dgvStudents.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 693);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(nudScience);
            Controls.Add(lblScience);
            Controls.Add(nudEnglish);
            Controls.Add(lblEnglish);
            Controls.Add(nudMath);
            Controls.Add(lblMath);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(label1);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Manager";
            ((System.ComponentModel.ISupportInitialize)nudMath).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScience).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label label1;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblMath;
        private NumericUpDown nudMath;
        private Label lblEnglish;
        private NumericUpDown nudEnglish;
        private Label lblScience;
        private NumericUpDown nudScience;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvStudents;
    }
}

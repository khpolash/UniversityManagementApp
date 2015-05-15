namespace UniversityManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.mobileNoTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.showStudentListView = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.deleteButton);
            this.GroupBox1.Controls.Add(this.saveButton);
            this.GroupBox1.Controls.Add(this.mobileNoTextBox);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.sessionTextBox);
            this.GroupBox1.Controls.Add(this.departmentTextBox);
            this.GroupBox1.Controls.Add(this.studentRegNoTextBox);
            this.GroupBox1.Controls.Add(this.studentNameTextBox);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(13, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(383, 230);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "New Student";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(264, 188);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 24);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Student";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mobileNoTextBox
            // 
            this.mobileNoTextBox.Location = new System.Drawing.Point(106, 153);
            this.mobileNoTextBox.Name = "mobileNoTextBox";
            this.mobileNoTextBox.Size = new System.Drawing.Size(247, 20);
            this.mobileNoTextBox.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(36, 157);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Mobile No";
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.Location = new System.Drawing.Point(106, 121);
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.Size = new System.Drawing.Size(247, 20);
            this.sessionTextBox.TabIndex = 7;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(106, 89);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(247, 20);
            this.departmentTextBox.TabIndex = 6;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(106, 57);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(247, 20);
            this.studentRegNoTextBox.TabIndex = 5;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(106, 25);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.studentNameTextBox.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(36, 125);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Session";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 93);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Department";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(50, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "RegNo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Student Name";
            // 
            // showStudentListView
            // 
            this.showStudentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.columnHeader6});
            this.showStudentListView.FullRowSelect = true;
            this.showStudentListView.GridLines = true;
            this.showStudentListView.Location = new System.Drawing.Point(12, 240);
            this.showStudentListView.Name = "showStudentListView";
            this.showStudentListView.Size = new System.Drawing.Size(655, 256);
            this.showStudentListView.TabIndex = 4;
            this.showStudentListView.UseCompatibleStateImageBehavior = false;
            this.showStudentListView.View = System.Windows.Forms.View.Details;
            this.showStudentListView.DoubleClick += new System.EventHandler(this.showStudentListView_DoubleClick_1);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 41;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Name";
            this.ColumnHeader2.Width = 76;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "RegNo";
            this.ColumnHeader3.Width = 142;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Department";
            this.ColumnHeader4.Width = 142;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Session";
            this.ColumnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mobile No";
            this.columnHeader6.Width = 127;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 188);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 24);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete Student";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 507);
            this.Controls.Add(this.showStudentListView);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "University Management UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button saveButton;
        internal System.Windows.Forms.TextBox mobileNoTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox sessionTextBox;
        internal System.Windows.Forms.TextBox departmentTextBox;
        internal System.Windows.Forms.TextBox studentRegNoTextBox;
        internal System.Windows.Forms.TextBox studentNameTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListView showStudentListView;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button deleteButton;
    }
}


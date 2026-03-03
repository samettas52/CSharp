namespace Project2
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
            lbxStudentList = new ListBox();
            lblStudentList = new Label();
            lblStudentName = new Label();
            tbxStudentName = new TextBox();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            SuspendLayout();
            // 
            // lbxStudentList
            // 
            lbxStudentList.Font = new Font("Segoe UI", 12F);
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.ItemHeight = 28;
            lbxStudentList.Location = new Point(44, 114);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new Size(163, 228);
            lbxStudentList.TabIndex = 0;
            lbxStudentList.SelectedIndexChanged += lbxStudentList_SelectedIndexChanged;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI", 12F);
            lblStudentList.Location = new Point(44, 78);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(65, 28);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "label1";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F);
            lblStudentName.Location = new Point(306, 78);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(65, 28);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "label1";
            // 
            // tbxStudentName
            // 
            tbxStudentName.Font = new Font("Segoe UI", 12F);
            tbxStudentName.Location = new Point(306, 114);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(335, 34);
            tbxStudentName.TabIndex = 3;
            tbxStudentName.TextChanged += tbxStudentName_TextChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 12F);
            btnAddStudent.Location = new Point(497, 163);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(144, 37);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "button1";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += button1_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Segoe UI", 12F);
            btnRemoveStudent.Location = new Point(63, 359);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(144, 37);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "button2";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentList);
            Controls.Add(lbxStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxStudentList;
        private Label lblStudentList;
        private Label lblStudentName;
        private TextBox tbxStudentName;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
    }
}

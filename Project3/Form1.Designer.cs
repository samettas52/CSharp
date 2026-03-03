namespace Project3
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
            dgrwCustomers = new DataGridView();
            tbxId = new TextBox();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxCity = new TextBox();
            tbxEmail = new TextBox();
            lblId = new Label();
            lblFistName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            btnAddCustomer = new Button();
            gbxCustomerAdd = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxCustomerAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 51;
            dgrwCustomers.Size = new Size(1006, 188);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 12F);
            tbxId.Location = new Point(129, 36);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(230, 34);
            tbxId.TabIndex = 1;
            tbxId.TextChanged += textBox1_TextChanged;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F);
            tbxFirstName.Location = new Point(129, 70);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(230, 34);
            tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F);
            tbxLastName.Location = new Point(129, 104);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(230, 34);
            tbxLastName.TabIndex = 3;
            tbxLastName.TextChanged += textBox3_TextChanged;
            // 
            // tbxCity
            // 
            tbxCity.Font = new Font("Segoe UI", 12F);
            tbxCity.Location = new Point(129, 172);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(230, 34);
            tbxCity.TabIndex = 4;
            tbxCity.TextChanged += textBox4_TextChanged;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F);
            tbxEmail.Location = new Point(129, 138);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(230, 34);
            tbxEmail.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.Location = new Point(15, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 28);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            lblId.Click += lblId_Click;
            // 
            // lblFistName
            // 
            lblFistName.AutoSize = true;
            lblFistName.Font = new Font("Segoe UI", 12F);
            lblFistName.Location = new Point(15, 69);
            lblFistName.Name = "lblFistName";
            lblFistName.Size = new Size(64, 28);
            lblFistName.TabIndex = 7;
            lblFistName.Text = "Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(15, 102);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Sure Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(15, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.Click += label4_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F);
            lblCity.Location = new Point(15, 168);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 28);
            lblCity.TabIndex = 10;
            lblCity.Text = "City";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 12F);
            btnAddCustomer.Location = new Point(257, 220);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(102, 41);
            btnAddCustomer.TabIndex = 11;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // gbxCustomerAdd
            // 
            gbxCustomerAdd.Controls.Add(tbxId);
            gbxCustomerAdd.Controls.Add(btnAddCustomer);
            gbxCustomerAdd.Controls.Add(tbxFirstName);
            gbxCustomerAdd.Controls.Add(lblCity);
            gbxCustomerAdd.Controls.Add(tbxLastName);
            gbxCustomerAdd.Controls.Add(lblEmail);
            gbxCustomerAdd.Controls.Add(tbxCity);
            gbxCustomerAdd.Controls.Add(lblLastName);
            gbxCustomerAdd.Controls.Add(tbxEmail);
            gbxCustomerAdd.Controls.Add(lblFistName);
            gbxCustomerAdd.Controls.Add(lblId);
            gbxCustomerAdd.Font = new Font("Segoe UI", 12F);
            gbxCustomerAdd.Location = new Point(0, 194);
            gbxCustomerAdd.Name = "gbxCustomerAdd";
            gbxCustomerAdd.Size = new Size(469, 303);
            gbxCustomerAdd.TabIndex = 12;
            gbxCustomerAdd.TabStop = false;
            gbxCustomerAdd.Text = "Add Customer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 629);
            Controls.Add(gbxCustomerAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxCustomerAdd.ResumeLayout(false);
            gbxCustomerAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxId;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxCity;
        private TextBox tbxEmail;
        private Label lblId;
        private Label lblFistName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblCity;
        private Button btnAddCustomer;
        private GroupBox gbxCustomerAdd;
    }
}

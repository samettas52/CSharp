namespace Project1
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
            lblProducts = new Label();
            lbxProducts = new ListBox();
            btnAddToCart = new Button();
            lbxCart = new ListBox();
            lblCart = new Label();
            btnRemoveFromCart = new Button();
            SuspendLayout();
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.Location = new Point(26, 73);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 28);
            lblProducts.TabIndex = 1;
            lblProducts.Click += lblProducts_Click;
            // 
            // lbxProducts
            // 
            lbxProducts.Font = new Font("Segoe UI", 12F);
            lbxProducts.FormattingEnabled = true;
            lbxProducts.ItemHeight = 28;
            lbxProducts.Location = new Point(26, 104);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new Size(139, 228);
            lbxProducts.TabIndex = 2;
            lbxProducts.SelectedIndexChanged += lbxProducts_SelectedIndexChanged_1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(186, 104);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 29);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.Font = new Font("Segoe UI", 12F);
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 28;
            lbxCart.Location = new Point(318, 104);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(145, 228);
            lbxCart.TabIndex = 4;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 12F);
            lblCart.Location = new Point(318, 73);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(0, 28);
            lblCart.TabIndex = 5;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(489, 104);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(156, 29);
            btnRemoveFromCart.TabIndex = 6;
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 631);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lbxProducts);
            Controls.Add(lblProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProducts;
        private ListBox lbxProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
    }
}

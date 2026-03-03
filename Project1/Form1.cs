namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // give the label dinamic texts
            var productsText = "Products";
            lblProducts.Text = productsText;
            var cartText = "Cart";
            lblCart.Text = cartText;
            // give the listbox dinamic items
            string[] products = { "Laptop", "Computer", "Keyboard" };
            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }
            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}
            //lbxProducts.Items.Add(products[0]);
            //lbxProducts.Items.Add(products[1]);
            //lbxProducts.Items.Add(products[2]);


            // give the button dinamic texts
            var AddToCartButtonText = "Add to Cart";
            btnAddToCart.Text = AddToCartButtonText;
            var RemoveFromCartButtonText = "Remove from Cart";
            btnRemoveFromCart.Text = RemoveFromCartButtonText;

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
         
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;

            }
            else
            {
                MessageBox.Show("Please select a product to add to the cart.");
            }
        }

        private void lbxProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            
            
            if (lbxCart.SelectedItem != null)
            {
             lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
             MessageBox.Show("Please select a product to remove from the cart");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
           
        }
    }
}

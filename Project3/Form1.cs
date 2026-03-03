namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();
        private void Form1_Load(object sender, EventArgs e)
        {
          
            dgrwCustomers.DataSource = customerManager.GetCustomers();
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
        
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;
            customerManager.AddCustomer(customer);
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetCustomers();
            MessageBox.Show("Customer added successfully!");
        }
    }
}

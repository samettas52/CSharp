namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //setting process
            product.Id = 1;
            //getting process
            Console.WriteLine(product.Id);
            product.UnitsInStock = 50;
            Console.WriteLine(product.UnitsInStock);
            product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);
        }
    }
    class Product
    {    //field  500
        decimal _unitPrice;
        public int Id { get; set; }

        public string ProductName { get; set; }
        public decimal UnitPrice
        {
            get { return _unitPrice + _unitPrice * 18 / 100; }  // get the _unitPrice
            set { _unitPrice = value; } //value = 500
        }
        // we made a constructure for using just setting process 
        public Product()
        {
            _unitPrice = 1000;
        }

        public decimal UnitsInStock;
        //generally we using auto property: {get; set; } but we made this for the understand property structure

    }
}

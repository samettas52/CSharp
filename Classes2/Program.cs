using System;
namespace Classes2
{
    class Program
    {
        //instance 
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.UnitPrice = 5000;
            product1.UnitsInStock = 3;
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
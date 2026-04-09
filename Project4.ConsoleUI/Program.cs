using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;
using System.Net.Http.Headers;

namespace Project4.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            //We are testing to see if the exception will execute.
            //It breaks the execution when we add the product if it's name is Laptop .
            //But we don't want that it breaks execution so we add try catch block . 
            try
            {
                productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "Modern Laptop", UnitPrice = 10000, UnitsInStock = 20 });
            }
            catch (Exception exception)
            {
                //this one is not our exception message 
                Console.WriteLine(exception.Message);
            }
            //Sometimes this exception thing gives some things that we don't want to share. 
            //An example
            try
            {
                productManager.Add(new Product { ProductId = 10, ProductName = "Table", QuantityPerUnit = "Modern Table", UnitPrice = 10000, UnitsInStock = 20 });
            }
            catch (DuplicateProductException exception)
            {
                //finally we giving our exception message to ui layer.
                //so we did the safely excepiton messsage.
                Console.WriteLine(exception.Message);
            }
        }
    }
}

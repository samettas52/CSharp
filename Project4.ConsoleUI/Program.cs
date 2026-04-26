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
            //ProductManager productManager = new ProductManager(new EfProductDal());
            ////the product will be outomaticly added to the table with the next id
            //productManager.Add(new Product { ProductName = "Table", CategoryId = 2, QuantityPerUnit = "Modern Table", UnitPrice = 1000, UnitsInStock = 20 });
            //productManager.Update(new Product { ProductId = 78, ProductName = "Table2", CategoryId = 2, QuantityPerUnit = "Modern Table2", UnitPrice = 1200, UnitsInStock = 4 });
            ////we can't remove the relationed products .
            ////but in this example has no relation so we can delete the product who has that product id
            //productManager.Delete(new Product { ProductId = 2082 });

            //Console.WriteLine(productManager.GetById(1).ProductName);

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //we don't need to give the productid because database gives it automatically when we add new product.
            //We are testing to see if the exception will execute.
            //It breaks the execution when we add the product if it's name is Laptop .
            //But we don't want that it breaks execution so we add try catch block . 
            //try
            //{
            //    productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "Modern Laptop", UnitPrice = 10000, UnitsInStock = 20 });
            //}
            //catch (Exception exception)
            //{
            //    //this one is not our exception message 
            //    Console.WriteLine(exception.Message);
            //}
            ////Sometimes this exception thing gives some things that we don't want to share. 
            ////An example
            //try
            //{
            //    productManager.Add(new Product { ProductId = 10, ProductName = "Table", QuantityPerUnit = "Modern Table", UnitPrice = 10000, UnitsInStock = 20 });
            //}
            //catch (DuplicateProductException exception)
            //{
            //    //finally we giving our exception message to ui layer.
            //    //so we did the safely excepiton messsage.
            //    Console.WriteLine(exception.Message);
            //}

            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2} ", personel.Id, personel.Name, personel.LastName);
            }
        }
    }
}

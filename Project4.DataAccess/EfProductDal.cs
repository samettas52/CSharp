using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        //List<Product> _products;
        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //  new Product{ProductId=1,ProductName="Acer ef Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=2},
            //  new Product{ProductId=2,ProductName="Asus ef Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=1},
            //  new Product{ProductId=3,ProductName="Hp ef Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=0},
            //  new Product{ProductId=4,ProductName="Mav ef Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=3},
            //  new Product{ProductId=5,ProductName="Dell ef Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=10}
            //};
        }
        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                //it saves the changes(it is normally using for more than one process)
                //we don't need it for this add function 
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //we need to macth the line of product in database 
                context.Products.Remove(context.Products.SingleOrDefault(p=>p.ProductId==product.ProductId));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            // we write like that because normally garbage collector is taking this 
            // but when we write like that it is not waiting the garbage collecter
            // it dispose it's self before the garbage collector get that .
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }

        }

        public Product GetById(int id)
        {
            //when we need just one object we use this 
            //singleordefault = get that object who has that id (if object be more than one it gives error)
            //firstordefault = get that object who has that id (if object be more than one it gives the first one )
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId==id);   
            }
        }       

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //we are finding the first version of product in database and saving in productoupdate
                //and we are giving updates of product 
               var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                context.SaveChanges();
            }
        }
    }
}

using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class XProductDal : IProductDal
    {
        List<Product> _products;
        public XProductDal()
        {
            _products = new List<Product>
            {
              new Product{ProductId=1,ProductName="Acer x Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=2},
              new Product{ProductId=2,ProductName="Asus x Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=1},
              new Product{ProductId=3,ProductName="Hp x Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=0},
              new Product{ProductId=4,ProductName="Mav x Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=3},
              new Product{ProductId=5,ProductName="Dell x Computer",QuantityPerUnit="32 Gb Ram",UnitPrice=10000,UnitsInStock=10}
            };
        }
        public void Add(Product product)
        {
        //    An example exception for the example of ui layer 
        //    throw new Exception("Unable connect to the  database . xxxx password is not correct");
            Console.WriteLine("Added with X");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project4.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)    
        {
            //we selected data access layer type
            _productDal = productDal;
        }
        //we add an exception query in add function 
        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                //throw new Exception("You cannot add the Laptop.");
                //we are getting our exception's message from here
                throw new DuplicateProductException("You cannot add the Laptop");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            //we can write the business codes in here
            return _productDal.GetAll();
        }
    }
}

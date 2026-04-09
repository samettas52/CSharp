using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Business
{
    public class ProductManager
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)    
        {
            //we selected data access layer type
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //we can write the work codes in here
            return _productDal.GetAll();
        }
    }
}

using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        //we are getting them from IEntityRepository 
        //List<Customer> GetAll();
        //List<Customer> GetById(int id);
        //void Add(Customer customer);
        //void Update(Customer customer);
        //void Delete(Customer customer);

    }
}

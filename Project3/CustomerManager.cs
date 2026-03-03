using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        List<Customer> customers;
        public CustomerManager()
        {

          
            customers = new List<Customer>()
            {
                new Customer { Id = 1, FirstName = "Samet1", LastName = "Tas", City = "Tekirdag", Email = "Samet1@" },
                new Customer { Id = 2, FirstName = "Samet2", LastName = "Tas", City = "Tekirdag", Email = "Samet2@" },
                new Customer { Id = 3, FirstName = "Samet3", LastName = "Tas", City = "Tekirdag", Email = "Samet3@" },
                new Customer { Id = 4, FirstName = "Samet4", LastName = "Tas", City = "Tekirdag", Email = "Samet4@" },
                new Customer { Id = 5, FirstName = "Samet5", LastName = "Tas", City = "Tekirdag", Email = "Samet5@" }
            };
        }

        public List<Customer> GetCustomers()
        {
            //It comes from database

            return customers;
        }



        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add();
            personManager.Update();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.GetBestCustomer();
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();
            employeeManager.GetBestEmployee();

        }
    }
    class PersonManager()
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }

    class CustomerManager : PersonManager
    {
        public void GetBestCustomer()
        {
            Console.WriteLine("Best Customer");
        }
    }
    class EmployeeManager : PersonManager
    {
        public void GetBestEmployee()
        {
            Console.WriteLine("Best Employee");
        }
    }
    class Person
    {
        public int Id { get; set; } // database id
        public string NationalIdentity { get; set; }//TC No
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }
}

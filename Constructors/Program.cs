using System;
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custpmer1 = new Customer() { Id = 5, FirstName = "Samet", LastName = "Taş", City = "Tekirdağ" };
            Customer customer2 = new Customer(2, "Samet", "Taş", "Tekirdağ");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Samet";
            customer3.LastName = "Taş";
            customer3.City = "Tekirdağ";
            //we cant write customer2 properties because we didnt assign them in constructor
            //we just write deafult constuctor inside (if we didnt giving value in consturactor inside  )
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        //constructor with parameters for customer2 object
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        // default constructor
        public Customer()
        {
            Console.WriteLine("Constructor runned");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
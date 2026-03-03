using System;
namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // What is the output
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);//20

            //int,decimal,float,enum,boolean  =>  value  type

            // What is the output
            int[] sayilar1 = new int[] { 1, 2, 3, };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);//1000

            //array , class , interface => reference Type

            //What is the outputs
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Samet1";
            person2 = person1;
            person1.FirstName = "Samet2";
            Console.WriteLine(person2.FirstName);//Samet2

            Customer customer = new Customer();
            customer.FirstName = "Samet3";
            customer.CreditCardNumber = "1234567890";
            Person person3 = customer;
            //we can't  make equality like " employee = customer "because they aren't inherit they self 
            Console.WriteLine(person3.FirstName);//Samet3
            Console.WriteLine(((Customer)person3).CreditCardNumber);//We can access the customer class content in this way.

            Employee employee = new Employee();
            Console.WriteLine();
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);

        }
    }
    //base class is  Person 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        //if we write Employee Type we can just work on  employee 
        //if we write Customet Type we can just work on customer
        //if we write Person Type we can work on three of them !!!!
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
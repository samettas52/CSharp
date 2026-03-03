using System.Xml.Serialization;

namespace Interfaces
{
    class Program
    {
        // we can't new the interfaces
        static void Main(string[] args)
        {
            // the interfaces can take the reference number of class that implements the interface 
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());

        }
    }

    class PersonManager
    {
        //implemented operation
        //we should implements the all operations that we inherits classes
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        public void Add();
        public void Update();
    }
    class EmployeeManager : IPersonManager
    {
        //we implement here
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }
        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }
    class ProjectManager
    {

        public void Add(IPersonManager personManager)
        {
         
            personManager.Add();
        }
    }
}

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Id = 1;
            house.City = "Tekirdağ";
        }
    }
    // `internal` is the default access modifier of class, and we can use it within the same namespace.
    internal class Customer
    {

    }
}

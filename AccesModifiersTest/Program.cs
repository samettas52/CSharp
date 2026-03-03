using AccessModifiers;

namespace AccessModifiersTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if we add the AccessModifiers reference we can use the House class
            //but first we made  the House class public 
            House house = new House();
            house.Id = 1;
            //we cant access to the City property because it has İnternal access modifier
            //house.City = "Tekirdağ";

        }
    }
}

using System;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir" };
            sehirler = new string[4];
            sehirler[3] = "Bursa";
            Console.WriteLine(sehirler.Length);
            //we generally wait the it writes all cities but it only writes the last one because we have created a new array
            //and assigned it to the same variable and we have lost the reference of the old array and we can not access to it anymore.
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            // so we need to use lists.
            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }
            //we can also use lambda expressions to write the cities in the list.
            sehirler2.ForEach(sehir => Console.WriteLine(sehir));
            // we can also use the Contains method to check if a city is in the list.
            bool result =sehirler2.Contains("Ankara");
            Console.WriteLine(result);
        }
    }
}


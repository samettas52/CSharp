using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Matematik matematik = new Matematik();
            
            double sonuc = matematik.Toplama(5, 6);
            double sonuc2 = matematik.Toplama(sayi1:3,sayi2: 10);
            double sonuc3 = matematik.Cikarma(10, 5);
            Console.WriteLine(sonuc);
            //we using the params keyword to create a method that can take a variable number of arguments.
            //We can call this method with any number of arguments, and it will return the sum of those arguments.
            matematik.ToplaParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            matematik.ToplaParams(new double[] { 1, 2, 3 });
        }
    }
    // Method Overloading = we can create multiple methods with the same name but different parameters
    class Matematik
    {
       
        public double Toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        public double Toplama(double sayi1, double sayi2,double sayi3)
        {
            return sayi1 + sayi2+sayi3;
        }
        public double ToplaParams(params double[] sayilar)
        {
            double sonuc = 0;
            foreach (var sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
            // we can also use the Sum method of the array to get the sum of the elements in the array.
            //return sayilar.Sum();
        }
        public double Cikarma(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
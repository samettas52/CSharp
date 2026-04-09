using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionHandling
{
     class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Divide(20, 5));
        }
        
    }
    class Math
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        
        public decimal Divide(int n1, int n2)
        {
            //We only write the errors we foresee.
            //we will get the division operation exceptions in a try catch block .
            try
            {
                return n1 / n2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("catch executed . An error occurred");
                throw new DivideByZeroException(" The denominator cannot be zero.");
            }
            //this exception's meaning doesn't matter . we are writing it as an example.
            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch executed . A different error occurred");
                throw new DllNotFoundException();
            }
            //This block contains all excepitons . If we can't foresee an exception than this block execute. 
            catch (Exception exception)
            {
                Console.WriteLine("Catch executed . An exception occurred we didn't foresee");
                //It gives us the details of exception.
                Console.WriteLine(exception.InnerException);
                throw;
            }
            //This block always executes . It doesn't matter what's inside  the try and catch blocks.
            finally
            { Console.WriteLine("finally executed"); }
           
        }
    }
}

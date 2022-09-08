using System;
namespace HelloWorld
{
    internal class CheckPrime
    {
        public static void FindPrimeNumber() 
        { 
            
            Console.WriteLine("Enter the number:");
            
            int n =Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("It is not prime number");
            }
            else
            {
                Console.WriteLine("It is Prime number");

            }
        }
    }
}

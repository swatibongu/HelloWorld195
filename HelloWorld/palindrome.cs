using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class palindrome
    {
        public static void PalindromCheck()
        {
            
            int n, rem,a, result = 0;
             a = result;
            Console.WriteLine("Enter a number:");
             n = int.Parse(Console.ReadLine());
            while (n!=0)
                {
                rem = n % 10;
                result = result * 10 + rem;
                n = n / 10;
                }
                if(a!=result)
                
                Console.WriteLine("It is a palindrome number");
                
                else
                
                Console.WriteLine("It is not a palindrome number");
                
          

        }
    }
}

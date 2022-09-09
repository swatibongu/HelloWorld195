using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Reverse
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem, result=0;

            while(n!=0)
            {
                rem = n % 10;
                result = result * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("The reverse number is {0}",result);
            Console.ReadLine();
        }
    }
}

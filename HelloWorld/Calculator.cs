using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text; 
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Calculator
    {
        public static void Calculatingsums()
        {
            int add,mul,sub,div,mod;
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int b = Convert.ToInt32(Console.ReadLine());
          
            add = a + b;
            mul = a * b;
            sub = a - b;
            div = a / b;
            mod = a % b;
            Console.WriteLine("The summings are \n{0}\n{1}\n{2}\n{3}\n{4}",add,mul,sub,div,mod);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC1
    {
        public static void abc()
        {
            int Full_Time = 1;
            Random rd = new Random();
            int EmpCheck = rd.Next(0,5);
            if (EmpCheck == Full_Time)

                Console.WriteLine("Employee is present.");

            else
                Console.WriteLine("Employee is absent.");
        }
    }
}

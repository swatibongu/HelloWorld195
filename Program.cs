using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC5
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMPRATE = 20;
        public const int NUM_OF_WORK_DAYS = 20;

        public static void ijk()
        {
            int emphrs = 0;
            int empwage = 0;
            int TotalEmpWage = 0;

            for (int i = 0; i < NUM_OF_WORK_DAYS; i++)
            {
                Random rd = new Random();
                int empCheck = rd.Next(0, 20);
                switch (empCheck)
                {
                    case PART_TIME:
                        emphrs = 4;
                        break;
                    case FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMPRATE;
                TotalEmpWage += empwage;
                Console.WriteLine("Employee Wage is:" + empwage);
            }
            Console.WriteLine("Total Employee wage is: " + TotalEmpWage);
        }
    }
}


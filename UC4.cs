using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC4
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public static void fgh()
        {

            int EmpRate = 20;
            int empHrs = 0;
            int empWage = 0;

            Random rd = new Random();
            int empCheck = rd.Next(0, 3);

            switch (empCheck)
            {
                case PART_TIME:
                    empHrs = 4;
                    break;
                case FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EmpRate;
            Console.WriteLine("Employee wage is:" + empWage);
        }
    }
}
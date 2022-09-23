using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC7
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMPRATE = 20;
        public const int NUM_OF_WORK_DAYS = 20;
        public const int Max_Hrs_In_Mnth = 80;

        public static int computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Mnth && totalWorkingDays < NUM_OF_WORK_DAYS)
            {
                totalWorkingDays++;
                Random rd = new Random();
                int empCheck = rd.Next(3, 100);
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day{0}:" + totalEmpHrs + "Employee hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMPRATE;
            Console.WriteLine("Total Employee Wage :" + totalEmpWage);
            return totalEmpWage;
        }
        public static void main(string[] args)
        {
            computeEmpWage();
        }
    }
}

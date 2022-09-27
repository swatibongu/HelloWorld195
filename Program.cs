using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC3
    {
        public static void dbc()
        {
            int Part_Time = 1;
            int Full_Time = 2;
            int empHrs = 0;
            int empWage = 0;
            int EmpRate = 20;
            Random rd = new Random();
            int empCheck = rd.Next(0, 3);
            if (empCheck == Part_Time)
            {
                empHrs = 4;
            }
            else if (empCheck == Full_Time)
            {
                empHrs = 8;
            }
            empWage = empHrs * EmpRate;
            Console.WriteLine("Employee wage is:" + empWage);

        }
    }
}


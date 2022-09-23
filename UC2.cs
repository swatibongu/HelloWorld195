using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgram
{
    internal class UC2
    {
        public static void EmpRate()
        {
            int Full_Day = 1;
            int Emp_hrs_rate = 20;
            int Emp_hrs = 0;
            int Emp_wage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == Full_Day)
            {

                Emp_hrs = 8;
            }
            else
            {
                Emp_hrs = 0;
            }
            Emp_wage = Emp_hrs * Emp_hrs_rate;
            Console.WriteLine("Emp wage is :" +Emp_wage);
        }
    }
}
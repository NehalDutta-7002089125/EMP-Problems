using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public static void check()
        {
            int FullTime = 1, FullTimeHr = 8;

            int EmpDailyWage = 20;

            int wage = 0;

            Random obj = new Random();

            int empCheck = obj.Next(0, 2);

            if (FullTime == empCheck)
            {
                wage = wage + (FullTimeHr * EmpDailyWage);

                Console.WriteLine("The total age is :" + wage);
            }
            else

            {
                Console.WriteLine("the total wage is" + wage);
            }
        }
    }
}

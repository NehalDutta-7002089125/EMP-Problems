using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public static void check()
        {
            int PartTime = 1, FullTime = 2; 
            FullTimeHr = 8, PartTimeHr = 4;

            int EmpDailyWage = 20;

            int wage = 0;

            Random obj = new Random();

            int empCheck = obj.Next(0, 3);

            if (PartTime == empCheck)
            {
                wage = wage + (FullTimeHr * EmpDailyWage);

                Console.WriteLine("The total age is :" + wage);
            }
            else if (FullTime == empCheck)
            {

                wage = wage + (PartTimeHr * EmpDailyWage);

                Console.WriteLine("The total age is :" + wage);

            }
        }
    }
}

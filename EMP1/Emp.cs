using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        public static void check()
        {
            int EmpPerHr = 20, wage = 0;

            int empHr = 0, TotalWage = 0, TotalWorkingDays = 20;


            Random obj = new Random();

            int empCheck = obj.Next(0, 3);

            switch (empCheck)
            {

                case PartTime:

                    empHr = 4 * TotalWorkingDays;
                    break;

                case FullTime:

                    empHr = 8 * TotalWorkingDays;
                    break;

                default:
                    empHr = 0;

                    break;

            }

            wage = empHr * EmpPerHr;
            TotalWage= wage;

            Console.WriteLine("The total wage is :" + TotalWage);

        }
    
    }
}

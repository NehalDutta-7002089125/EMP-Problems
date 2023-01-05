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
          int EmpPerHr = 20;

            int empHr = 4; 
            TotalWage = 0;


            Random obj = new Random();

            int empCheck = obj.Next(0, 3);

            switch (empCheck)
            {

                case PartTime:

                    empHr = 4;
                    break;

                case FullTime:

                    empHr = 8;
                    break;

                default:
                    empHr = 0;

                    break;

            }

            TotalWage = empHr * EmpPerHr;

            Console.WriteLine("The total wage is :" + TotalWage);

        }
    
    }
}

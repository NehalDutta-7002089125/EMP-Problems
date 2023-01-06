using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public const int TotalWorkingDays = 20;
        public const int EmpPerHr = 20
        public static void check()
        {
            int wage = 0;

            int empHr = 0, TotalWage = 0;
            
          for(int day=0; day<TotalWorkingDays; days++)
          {
            Random obj = new Random();

            int empCheck = obj.Next(0, 3);

            switch (empCheck)
            {

                case PartTime:

                    empHr = 4 ;
                    break;

                case FullTime:

                    empHr = 8 ;
                    break;

                default:
                    empHr = 0;

                    break;

            }

            wage = empHr * EmpPerHr;
            TotalWage += wage;
             Console.WriteLine("The wage is : "+ wage);
          }
            Console.WriteLine("The total wage is :" + TotalWage);

        }
    
    }
}

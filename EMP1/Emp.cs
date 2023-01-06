using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public const WagePerHr = 20;
        public const NoOfWorkingDays = 20;
        public const MaxWorkingHrs = 100;
        public static void check()
        {
            int wage = 0, empHr = 0;
            int totalEmpHr = 0, TotalWorkingDays = 0;
            while (totalEmpHr <= MaxWorkingHrs && TotalWorkingDays <= NoOfWorkingDays)
            {
                TotalWorkingDays++;

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
                totalEmpHr+ = empHr;

                Console.WriteLine("Days: " + TotalWorkingDays + " WorkingHr " + empHr);
            }
               wage = wage+ empHr* WagePerHr;

             Console.WriteLine("The total wage"+wage);

        }
    
    }
}

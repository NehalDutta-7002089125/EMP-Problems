using System;
using System.Collections.Generic;
using System.Text;

namespace EMP_problems
{
    internal class emp
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int EMPwage = 20;
            int FullTimeHr = 8;
            int TotalWage = 0;
            Random random = new Random();
            int CheckEMP = random.Next(0, 2);

            if (CheckEMP == 1)
            {
                TotalWage = TotalWage + EMPwage * FullTimeHr;
                Console.WriteLine("Employee wage is :" + TotalWage);
            }
            else
            {
                Console.WriteLine("Employee is absent" + TotalWage);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public static void check()
        {
            int FullTime = 1;

            Random obj = new Random();

            int empCheck = obj.Next(0, 2);

            if (empCheck == FullTime)
            {
                Console.WriteLine("Employee is Present");
            }

            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}

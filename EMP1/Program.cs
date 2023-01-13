using System;

namespace EMP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp obj= new Emp();
            obj.addCompanyWage("dmart", 20, 2, 10);
            obj.addCompanyWage("reliance", 25, 12, 30);
            obj.addCompanyWage("nike", 10, 13, 35);
            obj.computeEMPWage();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        private int noOfCompany = 0;
        private CompanyEMP [] CompanyEMPwageArray;

        public Emp()
        {
            this.CompanyEMPwageArray = new CompanyEMP[3];

        }
        public  void addCompanyWage(string company, int empPerHours, int NoOfWorkingDays, int maxHrsInMonth)
        {
            CompanyEMPwageArray[this.noOfCompany] = new CompanyEMP(company, empPerHours, NoOfWorkingDays, maxHrsInMonth);
            noOfCompany++;
        }
        public void check()
        {
            for(int i=0; i<noOfCompany; i++)
            {
                CompanyEMPwageArray[i].setcheck1(this.check(this.CompanyEMPwageArray[i]));
                Console.WriteLine(this.CompanyEMPwageArray[i].toString());
            }
        }
        private int check(CompanyEMP companyEMP)
        { 
            int totalEmpHr = 0, TotalWorkingDays = 0, empHr = 0;
            while (totalEmpHr <= companyEMP.maxHrsInMonth && TotalWorkingDays < companyEMP.NoOfWorkingDays)
            {
                TotalWorkingDays++;

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
                totalEmpHr += empHr;
                Console.WriteLine("Days" + TotalWorkingDays+ "emphr"+empHr);

            }

            return totalEmpHr * companyEMP.empPerHours;

        }   
    
    }
}

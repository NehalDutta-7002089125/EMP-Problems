using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    public class Emp: IComputeEMPWage
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        private LinkedList<CompanyEMP> CompanyEMPList;
        private Dictionary<string, CompanyEMP> CompanyEMPDictionary;

        public Emp()
        {
            this.CompanyEMPList = new LinkedList<CompanyEMP>();
            this.CompanyEMPDictionary= new Dictionary<string, CompanyEMP>();
        }
        public  void addCompanyWage(string company, int empPerHours, int NoOfWorkingDays, int maxHrsInMonth)
        {
            CompanyEMP a = new CompanyEMP(company, empPerHours,NoOfWorkingDays, maxHrsInMonth);
            this.CompanyEMPList.AddLast(a);
            this.CompanyEMPDictionary.Add(company, a);
        }
        public void computeEMPWage()
        {
            foreach(CompanyEMP a in this.CompanyEMPList)
            {
                a.setcheck1(this.computeEMPWage(a));
                Console.WriteLine(a.ToString());
            }
        
        }
        private int computeEMPWage(CompanyEMP companyEMP)
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
        public int getTotalWage(string company)
        {
            return this.CompanyEMPDictionary[company].TotalEmpWage;
        }


    }
}

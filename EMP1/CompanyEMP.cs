using System;
using System.Collections.Generic;
using System.Text;

namespace EMP1
{
    internal class CompanyEMP
    {
        public string company;
        public int empPerHours;
        public int NoOfWorkingDays ;
        public int maxHrsInMonth;
        public int TotalEmpWage;

        public CompanyEMP(string company, int empPerHours, int NoOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empPerHours = empPerHours;
            this.maxHrsInMonth = maxHrsInMonth;
            this.NoOfWorkingDays = NoOfWorkingDays;
        }
        public void setcheck1(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public string toString()
        {
            return "Total wage of compay" + this.company + "is" + this.TotalEmpWage;
        }
    }
}

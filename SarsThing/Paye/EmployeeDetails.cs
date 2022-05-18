using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsThing.Paye
{
    public class EmployeeDetails
    {
        public double MonthlySalaryExcludingBenefits { get; set; }
        public double MonthlyPayout { get; set; }
        public double MedicalAid { get; set; }
        public int NumberOfDependents { get; set; }
        public int Age { get; set; }
        public double Bonus { get; set; }
        public double TotalCostToCompany { get; set; }
    }
}

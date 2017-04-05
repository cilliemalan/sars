using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsThing.Paye
{
    public class CalculationResults
    {
        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public double Earnings { get { return BasicSalary + Bonus + Medical; } }
        public double Medical { get; set; }
        public double BasePaye { get; set; }
        public double MedicalRebate { get; set; }
        public double Rebate { get; set; }
        public double Paye { get { return Math.Max(0, BasePaye - MedicalRebate - Rebate); } }
        public double EmployeeUif { get; set; }
        public double EmployerUif { get; set; }
        public double Deductions { get { return Paye + EmployeeUif; } }
        public double Payout { get { return BasicSalary - Deductions; } }
        public double Taxes { get { return Paye + EmployeeUif + EmployerUif; } }
    }
}

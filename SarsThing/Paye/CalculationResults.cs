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
        public double Medical { get; set; }
        public double MedicalAidTaxCredit { get; set; }
        public double BasePaye { get; set; }
        public double PrimaryRebate { get; set; }
        public double SecondaryRebate { get; set; }
        public double TertiaryRebate { get; set; }
        public double PayeLessRebate => Math.Max(0, BasePaye - TotalRebate);
        public double EmployeeUif { get; set; }
        public double EmployerUif { get; set; }
        public double TotalUif => EmployeeUif + EmployerUif;
        public double Earnings => BasicSalary + Bonus + Medical;
        public double TotalRebate => PrimaryRebate + SecondaryRebate + TertiaryRebate;
        public double Paye => Math.Max(0, PayeLessRebate - MedicalAidTaxCredit);
        public double Deductions => Paye + EmployeeUif;
        public double Payout => BasicSalary - Deductions;
        public double Taxes => Paye + EmployeeUif + EmployerUif;
    }
}

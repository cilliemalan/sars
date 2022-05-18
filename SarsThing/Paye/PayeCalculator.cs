using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsThing.Paye
{
    public class PayeCalculator
    {
        public CalculationResults Calculate(CalculationParameters parameters, EmployeeDetails employee, CalculationType calculationType)
        {
            if (parameters == null) throw new ArgumentNullException(nameof(parameters));
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            switch (calculationType)
            {
                case CalculationType.SpecifySalary:
                    return CalculatePayout(parameters, employee);
                case CalculationType.SpecifyPayout:
                    return CalculatePaye(parameters, employee);
                case CalculationType.SpecifyTotalCostToCompany:
                    return CalculateTcc(parameters, employee);
                default:
                    throw new ArgumentException(nameof(calculationType));
            }
        }

        private static CalculationResults CalculatePayout(CalculationParameters parameters, EmployeeDetails employee)
        {
            if (employee.MonthlySalaryExcludingBenefits == 0) throw new ArgumentException($"{nameof(employee.MonthlySalaryExcludingBenefits)} needs to be specified.", nameof(employee));
            if (employee.MedicalAid < 0) throw new ArgumentException($"{nameof(employee.MedicalAid)} is invalid.", nameof(employee));
            if (employee.MonthlySalaryExcludingBenefits < 0) throw new ArgumentException($"{nameof(employee.MonthlySalaryExcludingBenefits)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents < 0) throw new ArgumentException($"{nameof(employee.NumberOfDependents)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents <= 0 && employee.MedicalAid > 0) throw new ArgumentException($"Cannot have medical aid without dependents.", nameof(employee));
            if (employee.Age < 0) throw new ArgumentException($"{nameof(employee.Age)} is invalid.", nameof(employee));

            double yearlySalary = employee.MonthlySalaryExcludingBenefits * 12;
            double effectiveYearlySalary = yearlySalary + employee.MedicalAid * 12 + employee.Bonus * 12;

            //calculate paye
            Bracket relevantBracket = parameters.Brackets
                .FirstOrDefault(x => x.Division > effectiveYearlySalary)
                ?? parameters.Brackets.Last();

            double yearlyPaye = relevantBracket.Rate * (effectiveYearlySalary - relevantBracket.Subtraction) + relevantBracket.Appendage;

            bool primary = employee.Age < parameters.SecondaryRebateAge;
            bool secondary = employee.Age >= parameters.SecondaryRebateAge && employee.Age < parameters.TertiaryRebateAge;
            bool tertiary = employee.Age >= parameters.TertiaryRebateAge;

            //calculate tax rebate
            double primaryRebate = 0;
            double secondaryRebate = 0;
            double tertiaryRebate = 0;
            bool notaxes = false;

            if (employee.Age < parameters.SecondaryRebateAge)
            {
                if (effectiveYearlySalary > parameters.PrimaryThreshold)
                {
                    primaryRebate = parameters.PrimaryRebate;
                }
                else
                {
                    notaxes = true;
                }
            }
            else if (employee.Age >= parameters.SecondaryRebateAge && employee.Age < parameters.TertiaryRebateAge)
            {
                if (effectiveYearlySalary > parameters.SecondaryThreshold)
                {
                    primaryRebate = parameters.PrimaryRebate;
                    secondaryRebate = parameters.SecondaryRebate;
                }
                else
                {
                    notaxes = true;
                }
            }
            else if (employee.Age >= parameters.TertiaryRebateAge)
            {
                if (effectiveYearlySalary > parameters.TertiaryThreshold)
                {
                    primaryRebate = parameters.PrimaryRebate;
                    secondaryRebate = parameters.SecondaryRebate;
                    tertiaryRebate = parameters.TertiaryRebate;
                }
                else
                {
                    notaxes = true;
                }
            }

            //calculate medical rebate
            double medicalRebate = 0;

            int dependents = employee.NumberOfDependents;

            if (dependents > 0)
            {
                --dependents;
                medicalRebate += parameters.MedicalSchemeTaxpayerRebate;
            }

            if (dependents > 0)
            {
                --dependents;
                medicalRebate += parameters.MedicalSchemeFirstDependentRebate;
            }

            while (dependents > 0)
            {
                --dependents;
                medicalRebate += parameters.MedicalSchemeOtherDependentRebate;
            }

            //medical rebate is monthly so multiply by 12 for consistency
            medicalRebate *= 12;

            //calculate results
            var result = new CalculationResults
            {
                BasicSalary = yearlySalary / 12.0,
                BasePaye = notaxes ? 0 : yearlyPaye / 12.0,
                PrimaryRebate = notaxes ? 0 : primaryRebate / 12.0,
                SecondaryRebate = notaxes ? 0 : secondaryRebate / 12.0,
                TertiaryRebate = notaxes ? 0 : tertiaryRebate / 12.0,
                MedicalAidTaxCredit = notaxes ? 0 : medicalRebate / 12.0,
                Medical = employee.MedicalAid,
                EmployeeUif = CalculateUif(yearlySalary, parameters.EmployeeUif, parameters.UifCap),
                EmployerUif = CalculateUif(yearlySalary, parameters.EmployerUif, parameters.UifCap),
                Bonus = employee.Bonus
            };

            //fill in the payout
            employee.MonthlyPayout = result.Payout;

            return result;
        }

        private static double CalculateUif(double yearlySalary, double uifPercentage, double uifCap)
        {
            var salary = yearlySalary / 12;
            if (salary > uifCap) salary = uifCap;
            return salary * uifPercentage;
        }

        private CalculationResults CalculatePaye(CalculationParameters parameters, EmployeeDetails employee)
        {
            if (employee.MonthlyPayout == 0) throw new ArgumentException($"{nameof(employee.MonthlyPayout)} needs to be specified.", nameof(employee));
            if (employee.MedicalAid < 0) throw new ArgumentException($"{nameof(employee.MedicalAid)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents < 0) throw new ArgumentException($"{nameof(employee.NumberOfDependents)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents <= 0 && employee.MedicalAid > 0) throw new ArgumentException($"Cannot have medical aid without dependents.", nameof(employee));
            if (employee.Age < 0) throw new ArgumentException($"{nameof(employee.Age)} is invalid.", nameof(employee));

            var emp = new EmployeeDetails
            {
                Age = employee.Age,
                NumberOfDependents = employee.NumberOfDependents,
                MedicalAid = employee.MedicalAid
            };

            CalculationResults lastResult = null;

            var actualSalary = FindRoot(salary =>
            {
                emp.MonthlySalaryExcludingBenefits = salary;
                lastResult = CalculatePayout(parameters, emp);
                return lastResult.Payout - employee.MonthlyPayout;
            });

            //fill in the salary
            employee.MonthlySalaryExcludingBenefits = lastResult.BasicSalary;
            employee.TotalCostToCompany = lastResult.TotalCostToCompany;

            return lastResult;
        }

        private CalculationResults CalculateTcc(CalculationParameters parameters, EmployeeDetails employee)
        {
            if (employee.TotalCostToCompany == 0) throw new ArgumentException($"{nameof(employee.MonthlyPayout)} needs to be specified.", nameof(employee));
            if (employee.MedicalAid < 0) throw new ArgumentException($"{nameof(employee.MedicalAid)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents < 0) throw new ArgumentException($"{nameof(employee.NumberOfDependents)} is invalid.", nameof(employee));
            if (employee.NumberOfDependents <= 0 && employee.MedicalAid > 0) throw new ArgumentException($"Cannot have medical aid without dependents.", nameof(employee));
            if (employee.Age < 0) throw new ArgumentException($"{nameof(employee.Age)} is invalid.", nameof(employee));

            var emp = new EmployeeDetails
            {
                Age = employee.Age,
                NumberOfDependents = employee.NumberOfDependents,
                MedicalAid = employee.MedicalAid
            };

            CalculationResults lastResult = null;

            var actualSalary = FindRoot(salary =>
            {
                emp.MonthlySalaryExcludingBenefits = salary;
                lastResult = CalculatePayout(parameters, emp);
                return lastResult.TotalCostToCompany - employee.TotalCostToCompany;
            });

            //fill in the salary
            employee.MonthlySalaryExcludingBenefits = lastResult.BasicSalary;
            employee.TotalCostToCompany = lastResult.TotalCostToCompany;

            return lastResult;
        }

        private double FindRoot(Func<double, double> function, double a = 1, double b = 1000000, double tolerance = 1E-5, int maxIterations = 1000)
        {
            int n = 0;
            while (n <= maxIterations)
            {
                double c = (a + b) / 2;

                //calculate result from c
                double resultc = function(c);
                if (resultc == 0 || (resultc > 0 && resultc < tolerance) || (resultc < 0 && resultc > -tolerance)) return c;

                //calculate result from a
                double resulta = function(a);
                if (resulta == 0 || (resulta > 0 && resulta < tolerance) || (resulta < 0 && resulta > -tolerance)) return a;

                //narrow the bounds
                if ((resulta > 0 && resultc > 0) || (resulta < 0 && resultc < 0)) a = c;
                else b = c;

                ++n;
            }

            throw new Exception("Could not find root");
        }
    }
}

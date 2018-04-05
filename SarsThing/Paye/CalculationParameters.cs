using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsThing.Paye
{
    public class CalculationParameters
    {
        public static readonly CalculationParameters Sars2016 = Get2016();
        public static readonly CalculationParameters Sars2017 = Get2017();
        public static readonly CalculationParameters Sars2018 = Get2018();
        public static readonly CalculationParameters Sars2019 = Get2019();
        public static readonly CalculationParameters[] AllYears = new[] { Sars2016, Sars2017, Sars2018, Sars2019 };

        public int Year { get; private set; }
        public Bracket[] Brackets { get; private set; }
        public int PrimaryRebate { get; private set; }
        public int SecondaryRebate { get; private set; }
        public int TertiaryRebate { get; private set; }

        public int SecondaryRebateAge { get; private set; }
        public int TertiaryRebateAge { get; private set; }

        public int PrimaryThreshold { get; private set; }
        public int SecondaryThreshold { get; private set; }
        public int TertiaryThreshold { get; private set; }

        public double MedicalSchemeTaxpayerRebate { get; private set; }
        public double MedicalSchemeFirstDependentRebate { get; private set; }
        public double MedicalSchemeOtherDependentRebate { get; private set; }

        public double EmployerUif { get; private set; }
        public double EmployeeUif { get; private set; }
        public double UifCap { get; private set; } = 14872;

        private static CalculationParameters Get2016()
        {
            return new CalculationParameters
            {
                Year = 2016,
                Brackets = new[]
                {
                    new Bracket
                    {
                        Division = 181900,
                        Appendage = 0,
                        Rate = 0.18,
                        Subtraction = 0
                    },
                    new Bracket
                    {
                        Division = 284100,
                        Appendage = 23742,
                        Rate = 0.26,
                        Subtraction = 181900
                    },
                    new Bracket
                    {
                        Division = 393200,
                        Appendage = 59314,
                        Rate = 0.31,
                        Subtraction = 284100
                    },
                    new Bracket
                    {
                        Division = 550100,
                        Appendage = 93135,
                        Rate = 0.36,
                        Subtraction = 393200
                    },
                    new Bracket
                    {
                        Division = 701300,
                        Appendage = 149619,
                        Rate = 0.39,
                        Subtraction = 550100
                    },
                    new Bracket
                    {
                        Division = int.MaxValue,
                        Appendage = 208587,
                        Rate = 0.41,
                        Subtraction = 701300
                    },
                },
                PrimaryRebate = 13257,
                PrimaryThreshold = 73650,
                SecondaryRebateAge = 65,
                SecondaryRebate = 7407,
                SecondaryThreshold = 114800,
                TertiaryRebateAge = 75,
                TertiaryRebate = 2466,
                TertiaryThreshold = 128500,
                MedicalSchemeTaxpayerRebate = 270,
                MedicalSchemeFirstDependentRebate = 270,
                MedicalSchemeOtherDependentRebate = 181,
                EmployeeUif = 0.01,
                EmployerUif = 0.01
            };
        }

        private static CalculationParameters Get2017()
        {
            return new CalculationParameters
            {
                Year = 2017,
                Brackets = new[]
                {
                    new Bracket
                    {
                        Division = 188000,
                        Appendage = 0,
                        Rate = 0.18,
                        Subtraction = 0
                    },
                    new Bracket
                    {
                        Division = 293600,
                        Appendage = 33840,
                        Rate = 0.26,
                        Subtraction = 188000
                    },
                    new Bracket
                    {
                        Division = 406400,
                        Appendage = 61296,
                        Rate = 0.31,
                        Subtraction = 293600
                    },
                    new Bracket
                    {
                        Division = 550100,
                        Appendage = 96264,
                        Rate = 0.36,
                        Subtraction = 406400
                    },
                    new Bracket
                    {
                        Division = 701300,
                        Appendage = 147996,
                        Rate = 0.39,
                        Subtraction = 550100
                    },
                    new Bracket
                    {
                        Division = int.MaxValue,
                        Appendage = 206964,
                        Rate = 0.41,
                        Subtraction = 701300
                    },
                },
                PrimaryRebate = 13500,
                PrimaryThreshold = 75000,
                SecondaryRebateAge = 65,
                SecondaryRebate = 7407,
                SecondaryThreshold = 116150,
                TertiaryRebateAge = 75,
                TertiaryRebate = 2466,
                TertiaryThreshold = 129850,
                MedicalSchemeTaxpayerRebate = 286,
                MedicalSchemeFirstDependentRebate = 286,
                MedicalSchemeOtherDependentRebate = 192,
                EmployeeUif = 0.01,
                EmployerUif = 0.01
            };
        }

        private static CalculationParameters Get2018()
        {
            return new CalculationParameters
            {
                Year = 2018,
                Brackets = new[]
                {
                    new Bracket
                    {
                        Division = 189880,
                        Appendage = 0,
                        Rate = 0.18,
                        Subtraction = 0
                    },
                    new Bracket
                    {
                        Division = 296540,
                        Appendage = 34178,
                        Rate = 0.26,
                        Subtraction = 189880
                    },
                    new Bracket
                    {
                        Division = 410460,
                        Appendage = 61910,
                        Rate = 0.31,
                        Subtraction = 296540
                    },
                    new Bracket
                    {
                        Division = 555600,
                        Appendage = 97225,
                        Rate = 0.36,
                        Subtraction = 410460
                    },
                    new Bracket
                    {
                        Division = 708310,
                        Appendage = 149475,
                        Rate = 0.39,
                        Subtraction = 555600
                    },
                    new Bracket
                    {
                        Division = 1500000,
                        Appendage = 209032,
                        Rate = 0.41,
                        Subtraction = 708310
                    },
                    new Bracket
                    {
                        Division = int.MaxValue,
                        Appendage = 533625,
                        Rate = 0.45,
                        Subtraction = 1500000
                    },
                },
                PrimaryRebate = 13635,
                PrimaryThreshold = 75750,
                SecondaryRebateAge = 65,
                SecondaryRebate = 7479,
                SecondaryThreshold = 117300,
                TertiaryRebateAge = 75,
                TertiaryRebate = 2493,
                TertiaryThreshold = 131150,
                MedicalSchemeTaxpayerRebate = 303,
                MedicalSchemeFirstDependentRebate = 303,
                MedicalSchemeOtherDependentRebate = 204,
                EmployeeUif = 0.01,
                EmployerUif = 0.01
            };
        }

        private static CalculationParameters Get2019()
        {
            return new CalculationParameters
            {
                Year = 2019,
                Brackets = new[]
                {
                    new Bracket
                    {
                        Division = 195850,
                        Appendage = 0,
                        Rate = 0.18,
                        Subtraction = 0
                    },
                    new Bracket
                    {
                        Division = 305850,
                        Appendage = 35253,
                        Rate = 0.26,
                        Subtraction = 195850
                    },
                    new Bracket
                    {
                        Division = 423300,
                        Appendage = 63853,
                        Rate = 0.31,
                        Subtraction = 305850
                    },
                    new Bracket
                    {
                        Division = 555600,
                        Appendage = 100263,
                        Rate = 0.36,
                        Subtraction = 423300
                    },
                    new Bracket
                    {
                        Division = 708310,
                        Appendage = 147891,
                        Rate = 0.39,
                        Subtraction = 555600
                    },
                    new Bracket
                    {
                        Division = 1500000,
                        Appendage = 207448,
                        Rate = 0.41,
                        Subtraction = 708310
                    },
                    new Bracket
                    {
                        Division = int.MaxValue,
                        Appendage = 532041,
                        Rate = 0.45,
                        Subtraction = 1500000
                    },
                },
                PrimaryRebate = 14067,
                PrimaryThreshold = 78150,
                SecondaryRebateAge = 65,
                SecondaryRebate = 7713,
                SecondaryThreshold = 121000,
                TertiaryRebateAge = 75,
                TertiaryRebate = 2574,
                TertiaryThreshold = 135300,
                MedicalSchemeTaxpayerRebate = 310,
                MedicalSchemeFirstDependentRebate = 310,
                MedicalSchemeOtherDependentRebate = 209,
                EmployeeUif = 0.01,
                EmployerUif = 0.01
            };
        }
    }
}

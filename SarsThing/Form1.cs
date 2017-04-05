using SarsThing.Paye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarsThing
{
    public partial class Form1 : Form
    {
        private bool recurseProtect = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateCheckedChanged(object sender, EventArgs e)
        {
            if (rdCalculatePayout.Checked)
            {
                txtPayout.Enabled = false;
                txtSalary.Enabled = true;
            }
            else
            {
                txtPayout.Enabled = true;
                txtSalary.Enabled = false;
            }

            Recalculate();
        }

        private void Recalculate()
        {
            if (recurseProtect) return;

            Action<TextBox> MakeBad = c => { c.ForeColor = Color.Red; };
            Action<TextBox> MakeGood = c => { c.ForeColor = SystemColors.ControlText; };
            Func<double, string> Format = d => d.ToString("c");

            int iAge;
            double dSalary;
            double dPayout;
            double dMedicalAid;
            double dBonus;
            int iDependents;
            bool benefitsIncluded = chkBenefitsIncluded.Checked;

            bool couldParseAge = int.TryParse(txtAge.Text, out iAge);
            bool couldParseSalary = double.TryParse(txtSalary.Text, out dSalary);
            bool couldParsePayout = double.TryParse(txtPayout.Text, out dPayout);
            bool couldParseMedicalAid = double.TryParse(txtMedicalAid.Text, out dMedicalAid);
            bool couldParseDependents = int.TryParse(txtDependents.Text, out iDependents);
            bool couldParseBonus = double.TryParse(txtBonus.Text, out dBonus);

            CalculationType calculation = rdCalculatePayout.Checked ? CalculationType.Payout : CalculationType.Paye;

            List<string> errors = new List<string>();
            List<TextBox> badControls = new List<TextBox>();
            List<TextBox> goodControls = new List<TextBox>();

            if (!couldParseAge || iAge < 16) { errors.Add("Invalid age"); badControls.Add(txtAge); } else goodControls.Add(txtAge);
            if (calculation == CalculationType.Payout && (!couldParseSalary || dSalary < 0)) { errors.Add("Invalid salary"); badControls.Add(txtSalary); } else goodControls.Add(txtSalary);
            if (calculation == CalculationType.Paye && (!couldParsePayout || dPayout < 0)) { errors.Add("Invalid payout"); badControls.Add(txtPayout); } else goodControls.Add(txtPayout);
            if (!couldParseMedicalAid || dMedicalAid < 0) { errors.Add("Invalid medical aid"); badControls.Add(txtMedicalAid); } else goodControls.Add(txtMedicalAid);
            if (!couldParseDependents || iDependents < 0) { errors.Add("Invalid dependents"); badControls.Add(txtDependents); } else goodControls.Add(txtDependents);
            if (!couldParseBonus || dBonus < 0) { errors.Add("Invalid bonus"); badControls.Add(txtBonus); } else goodControls.Add(txtBonus);

            if (!txtDependents.Focused)
            {
                if (dMedicalAid == 0 && iDependents != 0)
                {
                    iDependents = 0;
                    txtDependents.Text = "0";
                }
                else if (dMedicalAid > 0 && iDependents == 0)
                {
                    iDependents = 1;
                    txtDependents.Text = "1";
                }
            }

            if (iDependents == 0) dMedicalAid = 0;
            if (dMedicalAid == 0) iDependents = 0;

            badControls.ForEach(MakeBad);
            goodControls.ForEach(MakeGood);

            CalculationResults result = null;

            if (errors.Count == 0)
            {
                try
                {
                    if(benefitsIncluded)
                    {
                        dSalary -= dMedicalAid;
                    }


                    PayeCalculator calculator = new PayeCalculator();
                    result = calculator.Calculate(
                        CalculationParameters.Sars2018,
                        new EmployeeDetails
                        {
                            Age = iAge,
                            MonthlyPayout = dPayout,
                            MonthlySalaryExcludingBenefits = dSalary,
                            NumberOfDependents = iDependents,
                            MedicalAid = dMedicalAid,
                            Bonus = dBonus
                        },
                        calculation);

                    recurseProtect = true;
                    if (calculation == CalculationType.Payout) txtPayout.Text = result.Payout.ToString("F2");
                    if (calculation == CalculationType.Paye)
                    {
                        var value = result.BasicSalary;
                        if (benefitsIncluded) value += dMedicalAid;
                        txtSalary.Text = value.ToString("F2");
                    }
                    Invoke((Action)(() => recurseProtect = false));

                    if (result == null) errors.Add($"Calculation failed");
                }
                catch (Exception e)
                {
                    errors.Add($"Calculation failed: {e.Message}");
                }
            }


            if (result == null)
            {
                txtResultBasic.Text = "";
                txtResultDeductions.Text = "";
                txtResultDependents.Text = "";
                txtResultEmployeeUif.Text = "";
                txtResultMedical.Text = "";
                txtResultMedicalRebate.Text = "";
                txtResultBasePaye.Text = "";
                txtResultTotalPaye.Text = "";
                txtResultPayout.Text = "";
                txtResultRebate.Text = "";
                txtResultTaxes.Text = "";
                txtResultBonus.Text = "";
                txtResultEarnings.Text = "";
            }
            else
            {
                txtResultBasic.Text = Format(result.BasicSalary);
                txtResultDeductions.Text = Format(result.Deductions);
                txtResultDependents.Text = Format(iDependents);
                txtResultEmployeeUif.Text = Format(result.EmployeeUif);
                txtResultMedical.Text = Format(result.Medical);
                txtResultMedicalRebate.Text = Format(result.MedicalRebate);
                txtResultBasePaye.Text = Format(result.BasePaye);
                txtResultTotalPaye.Text = Format(result.Paye);
                txtResultPayout.Text = Format(result.Payout);
                txtResultRebate.Text = Format(result.Rebate);
                txtResultTaxes.Text = Format(result.Taxes);
                txtResultBonus.Text = Format(result.Bonus);
                txtResultEarnings.Text = Format(result.Earnings);
            }

            txtErrors.Text = string.Join("\r\n", errors);
        }

        private void SomethingChanged(object sender, EventArgs e) => Recalculate();

        private void SomethingKey(object sender, KeyEventArgs e) => Recalculate();

        private void SomethingKeyPress(object sender, KeyPressEventArgs e) => Recalculate();

        private void FormLoad(object sender, EventArgs e) => Recalculate();
    }
}

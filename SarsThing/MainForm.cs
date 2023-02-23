using SarsThing.Paye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarsThing
{
    public partial class MainForm : Form
    {
        private bool recurseProtect = false;
        private readonly TextBox[] controls;

        private Dictionary<int, CalculationParameters> TaxYears { get; }

        private int SelectedTaxYear =>
            cmbTaxYear.SelectedItem is int
            ? (int)cmbTaxYear.SelectedItem
            : default(int);
        private CalculationParameters SelectedTaxYearParameters =>
            TaxYears.TryGetValue(SelectedTaxYear, out var year)
            ? year
            : CalculationParameters.AllYears.OrderByDescending(x => x.Year).First();

        public MainForm()
        {
            InitializeComponent();

            controls = typeof(MainForm).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => typeof(TextBox).IsAssignableFrom(x.FieldType))
                .Select(x => x.GetValue(this))
                .Where(x => x != null)
                .Cast<TextBox>()
                .ToArray();

            TaxYears = CalculationParameters.AllYears.ToDictionary(x => x.Year);

            cmbTaxYear.Items.AddRange(CalculationParameters.AllYears
                .Select(x => x.Year)
                .OrderBy(x => x)
                .Cast<object>()
                .ToArray());

            cmbTaxYear.SelectedIndex = cmbTaxYear.Items.IndexOf(GetCurrentTaxYear());

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtTotalCostToCompany.Focus();
        }


        private int GetCurrentTaxYear()
        {
            var now = DateTime.Now;
            if (now.Month < 3) return now.Year;
            else return now.Year + 1;
        }

        private void CalculateCheckedChanged(object sender, EventArgs e)
        {
            if (rdSpecifySalary.Checked)
            {
                txtSalary.Enabled = true;
                txtTotalCostToCompany.Enabled = false;
                txtPayout.Enabled = false;
            }
            else if (rdTotalCostToCompany.Checked)
            {
                txtSalary.Enabled = false;
                txtTotalCostToCompany.Enabled = true;
                txtPayout.Enabled = false;
            }
            else if (rdSpecifyPayout.Checked)
            {
                txtSalary.Enabled = false;
                txtTotalCostToCompany.Enabled = false;
                txtPayout.Enabled = true;
            }
            else
            {
                txtSalary.Enabled = false;
                txtTotalCostToCompany.Enabled = false;
                txtPayout.Enabled = false;
            }

            Recalculate();
        }

        private void Recalculate()
        {
            if (recurseProtect) return;

            void MakeBad(Control c) { c.ForeColor = Color.Red; }
            void MakeGood(Control c) { c.ForeColor = SystemColors.ControlText; }
            string Format(double d) => d.ToString("c");

            bool benefitsIncluded = chkBenefitsIncluded.Checked;
            bool couldParseAge = int.TryParse(txtAge.Text, out int iAge);
            bool couldParseSalary = double.TryParse(txtSalary.Text, out double dSalary);
            bool couldParsePayout = double.TryParse(txtPayout.Text, out double dPayout);
            bool couldParseTCC = double.TryParse(txtTotalCostToCompany.Text, out double dTCC);
            bool couldParseMedicalAid = double.TryParse(txtMedicalAid.Text, out double dMedicalAid);
            bool couldParseDependents = int.TryParse(txtDependents.Text, out int iDependents);
            bool couldParseBonus = double.TryParse(txtBonus.Text, out double dBonus);

            CalculationType calculation;
            if (rdSpecifyPayout.Checked) calculation = CalculationType.SpecifyPayout;
            else if (rdSpecifySalary.Checked) calculation = CalculationType.SpecifySalary;
            else if (rdTotalCostToCompany.Checked) calculation = CalculationType.SpecifyTotalCostToCompany;
            else calculation = CalculationType.SpecifySalary;

            List<string> errors = new List<string>();
            List<TextBox> badControls = new List<TextBox>();

            if (!couldParseAge || iAge < 16)
            {
                errors.Add("Invalid age");
                badControls.Add(txtAge);
            }

            switch (calculation)
            {
                case CalculationType.SpecifyPayout:
                    if (!couldParsePayout || dPayout < 0)
                    {
                        errors.Add("Invalid payout");
                        badControls.Add(txtPayout);
                    }
                    break;
                case CalculationType.SpecifySalary:
                    if (!couldParseSalary || dSalary < 0)
                    {
                        errors.Add("Invalid salary");
                        badControls.Add(txtSalary);
                    }
                    break;
                case CalculationType.SpecifyTotalCostToCompany:
                    if (!couldParseTCC || dTCC < 0)
                    {
                        errors.Add("Invalid TCC");
                        badControls.Add(txtTotalCostToCompany);
                    }
                    break;
            }

            if (!couldParseMedicalAid || dMedicalAid < 0)
            {
                errors.Add("Invalid medical aid");
                badControls.Add(txtMedicalAid);
            }
            if (!couldParseDependents || iDependents < 0)
            {
                errors.Add("Invalid dependents");
                badControls.Add(txtDependents);
            }
            if (!couldParseBonus || dBonus < 0)
            {
                errors.Add("Invalid bonus");
                badControls.Add(txtBonus);
            }

            if (!txtDependents.Focused)
            {
                if (dMedicalAid > 0 && iDependents == 0)
                {
                    iDependents = 1;
                    txtDependents.Text = "1";
                }
            }

            if (iDependents == 0) dMedicalAid = 0;

            badControls.ForEach(MakeBad);
            foreach (var ctl in controls.Except(badControls))
            {
                MakeGood(ctl);
            }

            CalculationResults result = null;

            if (errors.Count == 0)
            {
                try
                {
                    if (benefitsIncluded)
                    {
                        dSalary -= dMedicalAid;
                    }


                    PayeCalculator calculator = new PayeCalculator();
                    result = calculator.Calculate(
                        SelectedTaxYearParameters,
                        new EmployeeDetails
                        {
                            Age = iAge,
                            MonthlyPayout = dPayout,
                            MonthlySalaryExcludingBenefits = dSalary,
                            NumberOfDependents = iDependents,
                            MedicalAid = dMedicalAid,
                            Bonus = dBonus,
                            TotalCostToCompany = dTCC
                        },
                        calculation);

                    recurseProtect = true;
                    if (calculation == CalculationType.SpecifySalary)
                    {
                        txtPayout.Text = result.Payout.ToString("F2");
                        txtTotalCostToCompany.Text = result.TotalCostToCompany.ToString("F2");
                    }
                    else if (calculation == CalculationType.SpecifyPayout)
                    {
                        var value = result.BasicSalary;
                        if (benefitsIncluded) value += result.Medical;
                        txtSalary.Text = value.ToString("F2");
                        txtTotalCostToCompany.Text = result.TotalCostToCompany.ToString("F2");
                    }
                    else if (calculation == CalculationType.SpecifyTotalCostToCompany)
                    {
                        var salary = result.BasicSalary;
                        if (benefitsIncluded) salary += result.Medical;
                        txtSalary.Text = salary.ToString("F2");
                        txtPayout.Text = result.Payout.ToString("F2");
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
                txtResultMedicalTaxCredit.Text = "";
                txtResultBasePaye.Text = "";
                txtResultTotalPaye.Text = "";
                txtResultPayout.Text = "";
                txtResultPrimaryRebate.Text = "";
                txtResultSecondaryRebate.Text = "";
                txtResultTertiaryRebate.Text = "";
                txtResultPayeLessRebate.Text = "";
                txtResultTaxes.Text = "";
                txtResultBonus.Text = "";
                txtResultEarnings.Text = "";
                txtResultEmployerUif.Text = "";
                txtResultTotalUif.Text = "";
            }
            else
            {
                txtResultBasic.Text = Format(result.BasicSalary);
                txtResultDeductions.Text = Format(-result.Deductions);
                txtResultDependents.Text = iDependents.ToString();
                txtResultEmployeeUif.Text = Format(result.EmployeeUif);
                txtResultMedical.Text = Format(result.Medical);
                txtResultMedicalTaxCredit.Text = Format(-result.MedicalAidTaxCredit);
                txtResultBasePaye.Text = Format(result.BasePaye);
                txtResultTotalPaye.Text = Format(result.Paye);
                txtResultPayout.Text = Format(result.Payout);
                txtResultPrimaryRebate.Text = Format(-result.PrimaryRebate);
                txtResultSecondaryRebate.Text = Format(-result.SecondaryRebate);
                txtResultTertiaryRebate.Text = Format(-result.TertiaryRebate);
                txtResultPayeLessRebate.Text = Format(result.PayeLessRebate);
                txtResultEmployerUif.Text = Format(result.EmployerUif);
                txtResultTotalUif.Text = Format(result.TotalUif);
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

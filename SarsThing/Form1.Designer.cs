namespace SarsThing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicalAid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rdCalculateSalary = new System.Windows.Forms.RadioButton();
            this.rdCalculatePayout = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultBasic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultMedical = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResultDependents = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResultBasePaye = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultRebate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultMedicalRebate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResultEmployeeUif = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResultDeductions = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResultPayout = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtResultTaxes = new System.Windows.Forms.TextBox();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.txtResultTotalPaye = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtResultBonus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtResultEarnings = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkBenefitsIncluded = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(315, 44);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(211, 26);
            this.txtSalary.TabIndex = 0;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalary.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtSalary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total monthly salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPayout
            // 
            this.txtPayout.Enabled = false;
            this.txtPayout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayout.Location = new System.Drawing.Point(315, 76);
            this.txtPayout.Name = "txtPayout";
            this.txtPayout.Size = new System.Drawing.Size(211, 26);
            this.txtPayout.TabIndex = 2;
            this.txtPayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayout.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtPayout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtPayout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtPayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total monthly payout";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medical aid";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMedicalAid
            // 
            this.txtMedicalAid.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalAid.Location = new System.Drawing.Point(315, 195);
            this.txtMedicalAid.Name = "txtMedicalAid";
            this.txtMedicalAid.Size = new System.Drawing.Size(211, 26);
            this.txtMedicalAid.TabIndex = 4;
            this.txtMedicalAid.Text = "0";
            this.txtMedicalAid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMedicalAid.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtMedicalAid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtMedicalAid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtMedicalAid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Dependents (incl taxpayer)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDependents
            // 
            this.txtDependents.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependents.Location = new System.Drawing.Point(315, 227);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(211, 26);
            this.txtDependents.TabIndex = 6;
            this.txtDependents.Text = "0";
            this.txtDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDependents.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtDependents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtDependents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtDependents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Taxpayer age";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(315, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(211, 26);
            this.txtAge.TabIndex = 8;
            this.txtAge.Text = "18";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAge.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // rdCalculateSalary
            // 
            this.rdCalculateSalary.Location = new System.Drawing.Point(532, 44);
            this.rdCalculateSalary.Name = "rdCalculateSalary";
            this.rdCalculateSalary.Size = new System.Drawing.Size(203, 26);
            this.rdCalculateSalary.TabIndex = 10;
            this.rdCalculateSalary.Tag = "A";
            this.rdCalculateSalary.Text = "I want to calculate this";
            this.rdCalculateSalary.UseVisualStyleBackColor = true;
            this.rdCalculateSalary.CheckedChanged += new System.EventHandler(this.CalculateCheckedChanged);
            // 
            // rdCalculatePayout
            // 
            this.rdCalculatePayout.Checked = true;
            this.rdCalculatePayout.Location = new System.Drawing.Point(532, 76);
            this.rdCalculatePayout.Name = "rdCalculatePayout";
            this.rdCalculatePayout.Size = new System.Drawing.Size(203, 26);
            this.rdCalculatePayout.TabIndex = 11;
            this.rdCalculatePayout.TabStop = true;
            this.rdCalculatePayout.Tag = "A";
            this.rdCalculatePayout.Text = "I want to calculate this";
            this.rdCalculatePayout.UseVisualStyleBackColor = true;
            this.rdCalculatePayout.CheckedChanged += new System.EventHandler(this.CalculateCheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Basic Salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultBasic
            // 
            this.txtResultBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBasic.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBasic.Location = new System.Drawing.Point(315, 308);
            this.txtResultBasic.Name = "txtResultBasic";
            this.txtResultBasic.ReadOnly = true;
            this.txtResultBasic.Size = new System.Drawing.Size(211, 19);
            this.txtResultBasic.TabIndex = 13;
            this.txtResultBasic.Text = "0.00";
            this.txtResultBasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medical Aid";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultMedical
            // 
            this.txtResultMedical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultMedical.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultMedical.Location = new System.Drawing.Point(315, 405);
            this.txtResultMedical.Name = "txtResultMedical";
            this.txtResultMedical.ReadOnly = true;
            this.txtResultMedical.Size = new System.Drawing.Size(211, 19);
            this.txtResultMedical.TabIndex = 13;
            this.txtResultMedical.Text = "0.00";
            this.txtResultMedical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Number of Dependents";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultDependents
            // 
            this.txtResultDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultDependents.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDependents.Location = new System.Drawing.Point(315, 430);
            this.txtResultDependents.Name = "txtResultDependents";
            this.txtResultDependents.ReadOnly = true;
            this.txtResultDependents.Size = new System.Drawing.Size(211, 19);
            this.txtResultDependents.TabIndex = 13;
            this.txtResultDependents.Text = "0.00";
            this.txtResultDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Base PAYE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultBasePaye
            // 
            this.txtResultBasePaye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBasePaye.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBasePaye.Location = new System.Drawing.Point(315, 465);
            this.txtResultBasePaye.Name = "txtResultBasePaye";
            this.txtResultBasePaye.ReadOnly = true;
            this.txtResultBasePaye.Size = new System.Drawing.Size(211, 19);
            this.txtResultBasePaye.TabIndex = 13;
            this.txtResultBasePaye.Text = "0.00";
            this.txtResultBasePaye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Primary Rebate";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultRebate
            // 
            this.txtResultRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultRebate.Location = new System.Drawing.Point(315, 490);
            this.txtResultRebate.Name = "txtResultRebate";
            this.txtResultRebate.ReadOnly = true;
            this.txtResultRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultRebate.TabIndex = 13;
            this.txtResultRebate.Text = "0.00";
            this.txtResultRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "Medical Rebate";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultMedicalRebate
            // 
            this.txtResultMedicalRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultMedicalRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultMedicalRebate.Location = new System.Drawing.Point(315, 515);
            this.txtResultMedicalRebate.Name = "txtResultMedicalRebate";
            this.txtResultMedicalRebate.ReadOnly = true;
            this.txtResultMedicalRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultMedicalRebate.TabIndex = 13;
            this.txtResultMedicalRebate.Text = "0.00";
            this.txtResultMedicalRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Employee UIF";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultEmployeeUif
            // 
            this.txtResultEmployeeUif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultEmployeeUif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultEmployeeUif.Location = new System.Drawing.Point(315, 587);
            this.txtResultEmployeeUif.Name = "txtResultEmployeeUif";
            this.txtResultEmployeeUif.ReadOnly = true;
            this.txtResultEmployeeUif.Size = new System.Drawing.Size(211, 19);
            this.txtResultEmployeeUif.TabIndex = 13;
            this.txtResultEmployeeUif.Text = "0.00";
            this.txtResultEmployeeUif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 608);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Deductions";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultDeductions
            // 
            this.txtResultDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultDeductions.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDeductions.Location = new System.Drawing.Point(315, 612);
            this.txtResultDeductions.Name = "txtResultDeductions";
            this.txtResultDeductions.ReadOnly = true;
            this.txtResultDeductions.Size = new System.Drawing.Size(211, 19);
            this.txtResultDeductions.TabIndex = 13;
            this.txtResultDeductions.Text = "0.00";
            this.txtResultDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 648);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 26);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total Payout";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultPayout
            // 
            this.txtResultPayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultPayout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultPayout.Location = new System.Drawing.Point(315, 652);
            this.txtResultPayout.Name = "txtResultPayout";
            this.txtResultPayout.ReadOnly = true;
            this.txtResultPayout.Size = new System.Drawing.Size(211, 19);
            this.txtResultPayout.TabIndex = 13;
            this.txtResultPayout.Text = "0.00";
            this.txtResultPayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 687);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(297, 26);
            this.label15.TabIndex = 12;
            this.label15.Text = "Total Taxes due by Employer";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultTaxes
            // 
            this.txtResultTaxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTaxes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTaxes.Location = new System.Drawing.Point(315, 691);
            this.txtResultTaxes.Name = "txtResultTaxes";
            this.txtResultTaxes.ReadOnly = true;
            this.txtResultTaxes.Size = new System.Drawing.Size(211, 19);
            this.txtResultTaxes.TabIndex = 13;
            this.txtResultTaxes.Text = "0.00";
            this.txtResultTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtErrors
            // 
            this.txtErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtErrors.ForeColor = System.Drawing.Color.Red;
            this.txtErrors.Location = new System.Drawing.Point(0, 789);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ReadOnly = true;
            this.txtErrors.Size = new System.Drawing.Size(928, 58);
            this.txtErrors.TabIndex = 14;
            // 
            // txtResultTotalPaye
            // 
            this.txtResultTotalPaye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTotalPaye.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTotalPaye.Location = new System.Drawing.Point(315, 540);
            this.txtResultTotalPaye.Name = "txtResultTotalPaye";
            this.txtResultTotalPaye.ReadOnly = true;
            this.txtResultTotalPaye.Size = new System.Drawing.Size(211, 19);
            this.txtResultTotalPaye.TabIndex = 16;
            this.txtResultTotalPaye.Text = "0.00";
            this.txtResultTotalPaye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 536);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(297, 26);
            this.label16.TabIndex = 15;
            this.label16.Text = "Total PAYE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(297, 26);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bonus";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(315, 108);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(211, 26);
            this.txtBonus.TabIndex = 17;
            this.txtBonus.Text = "0";
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBonus.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtBonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtBonus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // txtResultBonus
            // 
            this.txtResultBonus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBonus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBonus.Location = new System.Drawing.Point(315, 334);
            this.txtResultBonus.Name = "txtResultBonus";
            this.txtResultBonus.ReadOnly = true;
            this.txtResultBonus.Size = new System.Drawing.Size(211, 19);
            this.txtResultBonus.TabIndex = 20;
            this.txtResultBonus.Text = "0.00";
            this.txtResultBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(12, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(297, 26);
            this.label18.TabIndex = 19;
            this.label18.Text = "Bonus";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultEarnings
            // 
            this.txtResultEarnings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultEarnings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultEarnings.Location = new System.Drawing.Point(315, 360);
            this.txtResultEarnings.Name = "txtResultEarnings";
            this.txtResultEarnings.ReadOnly = true;
            this.txtResultEarnings.Size = new System.Drawing.Size(211, 19);
            this.txtResultEarnings.TabIndex = 22;
            this.txtResultEarnings.Text = "0.00";
            this.txtResultEarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(12, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(297, 26);
            this.label19.TabIndex = 21;
            this.label19.Text = "Earnings";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkBenefitsIncluded
            // 
            this.chkBenefitsIncluded.AutoSize = true;
            this.chkBenefitsIncluded.Location = new System.Drawing.Point(684, 49);
            this.chkBenefitsIncluded.Name = "chkBenefitsIncluded";
            this.chkBenefitsIncluded.Size = new System.Drawing.Size(128, 17);
            this.chkBenefitsIncluded.TabIndex = 23;
            this.chkBenefitsIncluded.Text = "This includes benefits";
            this.chkBenefitsIncluded.UseVisualStyleBackColor = true;
            this.chkBenefitsIncluded.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 847);
            this.Controls.Add(this.chkBenefitsIncluded);
            this.Controls.Add(this.txtResultEarnings);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtResultBonus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtResultTotalPaye);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.txtResultTaxes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtResultPayout);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtResultDeductions);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtResultEmployeeUif);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtResultMedicalRebate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtResultRebate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultBasePaye);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResultDependents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResultMedical);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResultBasic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdCalculatePayout);
            this.Controls.Add(this.rdCalculateSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDependents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedicalAid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedicalAid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rdCalculateSalary;
        private System.Windows.Forms.RadioButton rdCalculatePayout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultBasic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultMedical;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResultDependents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResultBasePaye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResultRebate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResultMedicalRebate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResultEmployeeUif;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResultDeductions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResultPayout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtResultTaxes;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.TextBox txtResultTotalPaye;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtResultBonus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtResultEarnings;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkBenefitsIncluded;
    }
}


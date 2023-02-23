namespace SarsThing
{
    partial class MainForm
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
            this.rdSpecifySalary = new System.Windows.Forms.RadioButton();
            this.rdSpecifyPayout = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultBasic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultMedical = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResultDependents = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResultBasePaye = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultPrimaryRebate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultMedicalTaxCredit = new System.Windows.Forms.TextBox();
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
            this.txtResultTotalUif = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtResultSecondaryRebate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtResultTertiaryRebate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtResultPayeLessRebate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtResultEmployerUif = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbTaxYear = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.rdTotalCostToCompany = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTotalCostToCompany = new System.Windows.Forms.TextBox();
            this.gbxRemuneration = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxRemuneration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(156, 16);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(211, 26);
            this.txtSalary.TabIndex = 31;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalary.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtSalary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total monthly salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPayout
            // 
            this.txtPayout.Enabled = false;
            this.txtPayout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayout.Location = new System.Drawing.Point(156, 80);
            this.txtPayout.Name = "txtPayout";
            this.txtPayout.Size = new System.Drawing.Size(211, 26);
            this.txtPayout.TabIndex = 33;
            this.txtPayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayout.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtPayout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtPayout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtPayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total monthly payout";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medical aid";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMedicalAid
            // 
            this.txtMedicalAid.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalAid.Location = new System.Drawing.Point(204, 26);
            this.txtMedicalAid.Name = "txtMedicalAid";
            this.txtMedicalAid.Size = new System.Drawing.Size(211, 26);
            this.txtMedicalAid.TabIndex = 21;
            this.txtMedicalAid.Text = "0";
            this.txtMedicalAid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMedicalAid.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtMedicalAid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtMedicalAid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtMedicalAid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Dependents (incl taxpayer)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDependents
            // 
            this.txtDependents.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependents.Location = new System.Drawing.Point(204, 58);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(211, 26);
            this.txtDependents.TabIndex = 22;
            this.txtDependents.Text = "0";
            this.txtDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDependents.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtDependents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtDependents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtDependents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Taxpayer age";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(204, 16);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(211, 26);
            this.txtAge.TabIndex = 11;
            this.txtAge.Text = "18";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAge.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomethingKeyPress);
            this.txtAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SomethingKey);
            // 
            // rdSpecifySalary
            // 
            this.rdSpecifySalary.Location = new System.Drawing.Point(373, 16);
            this.rdSpecifySalary.Name = "rdSpecifySalary";
            this.rdSpecifySalary.Size = new System.Drawing.Size(203, 26);
            this.rdSpecifySalary.TabIndex = 34;
            this.rdSpecifySalary.Tag = "A";
            this.rdSpecifySalary.Text = "Specify this";
            this.rdSpecifySalary.UseVisualStyleBackColor = true;
            this.rdSpecifySalary.CheckedChanged += new System.EventHandler(this.CalculateCheckedChanged);
            // 
            // rdSpecifyPayout
            // 
            this.rdSpecifyPayout.Location = new System.Drawing.Point(373, 80);
            this.rdSpecifyPayout.Name = "rdSpecifyPayout";
            this.rdSpecifyPayout.Size = new System.Drawing.Size(203, 26);
            this.rdSpecifyPayout.TabIndex = 36;
            this.rdSpecifyPayout.Tag = "A";
            this.rdSpecifyPayout.Text = "Specify this";
            this.rdSpecifyPayout.UseVisualStyleBackColor = true;
            this.rdSpecifyPayout.CheckedChanged += new System.EventHandler(this.CalculateCheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Basic Salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultBasic
            // 
            this.txtResultBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBasic.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBasic.Location = new System.Drawing.Point(159, 214);
            this.txtResultBasic.Name = "txtResultBasic";
            this.txtResultBasic.ReadOnly = true;
            this.txtResultBasic.Size = new System.Drawing.Size(211, 19);
            this.txtResultBasic.TabIndex = 13;
            this.txtResultBasic.TabStop = false;
            this.txtResultBasic.Text = "0.00";
            this.txtResultBasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medical Aid";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultMedical
            // 
            this.txtResultMedical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultMedical.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultMedical.Location = new System.Drawing.Point(159, 315);
            this.txtResultMedical.Name = "txtResultMedical";
            this.txtResultMedical.ReadOnly = true;
            this.txtResultMedical.Size = new System.Drawing.Size(211, 19);
            this.txtResultMedical.TabIndex = 13;
            this.txtResultMedical.TabStop = false;
            this.txtResultMedical.Text = "0.00";
            this.txtResultMedical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Number of Dependents";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultDependents
            // 
            this.txtResultDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultDependents.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDependents.Location = new System.Drawing.Point(159, 340);
            this.txtResultDependents.Name = "txtResultDependents";
            this.txtResultDependents.ReadOnly = true;
            this.txtResultDependents.Size = new System.Drawing.Size(211, 19);
            this.txtResultDependents.TabIndex = 13;
            this.txtResultDependents.TabStop = false;
            this.txtResultDependents.Text = "0.00";
            this.txtResultDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Base PAYE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultBasePaye
            // 
            this.txtResultBasePaye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBasePaye.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBasePaye.Location = new System.Drawing.Point(159, 390);
            this.txtResultBasePaye.Name = "txtResultBasePaye";
            this.txtResultBasePaye.ReadOnly = true;
            this.txtResultBasePaye.Size = new System.Drawing.Size(211, 19);
            this.txtResultBasePaye.TabIndex = 13;
            this.txtResultBasePaye.TabStop = false;
            this.txtResultBasePaye.Text = "0.00";
            this.txtResultBasePaye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Primary Rebate";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultPrimaryRebate
            // 
            this.txtResultPrimaryRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultPrimaryRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultPrimaryRebate.Location = new System.Drawing.Point(159, 416);
            this.txtResultPrimaryRebate.Name = "txtResultPrimaryRebate";
            this.txtResultPrimaryRebate.ReadOnly = true;
            this.txtResultPrimaryRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultPrimaryRebate.TabIndex = 13;
            this.txtResultPrimaryRebate.TabStop = false;
            this.txtResultPrimaryRebate.Text = "0.00";
            this.txtResultPrimaryRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "Medical Aid Tax Credit";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultMedicalTaxCredit
            // 
            this.txtResultMedicalTaxCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultMedicalTaxCredit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultMedicalTaxCredit.Location = new System.Drawing.Point(159, 523);
            this.txtResultMedicalTaxCredit.Name = "txtResultMedicalTaxCredit";
            this.txtResultMedicalTaxCredit.ReadOnly = true;
            this.txtResultMedicalTaxCredit.Size = new System.Drawing.Size(211, 19);
            this.txtResultMedicalTaxCredit.TabIndex = 13;
            this.txtResultMedicalTaxCredit.TabStop = false;
            this.txtResultMedicalTaxCredit.Text = "0.00";
            this.txtResultMedicalTaxCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Employee UIF";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultEmployeeUif
            // 
            this.txtResultEmployeeUif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultEmployeeUif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultEmployeeUif.Location = new System.Drawing.Point(159, 549);
            this.txtResultEmployeeUif.Name = "txtResultEmployeeUif";
            this.txtResultEmployeeUif.ReadOnly = true;
            this.txtResultEmployeeUif.Size = new System.Drawing.Size(211, 19);
            this.txtResultEmployeeUif.TabIndex = 13;
            this.txtResultEmployeeUif.TabStop = false;
            this.txtResultEmployeeUif.Text = "0.00";
            this.txtResultEmployeeUif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 568);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Deductions";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultDeductions
            // 
            this.txtResultDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultDeductions.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDeductions.Location = new System.Drawing.Point(159, 575);
            this.txtResultDeductions.Name = "txtResultDeductions";
            this.txtResultDeductions.ReadOnly = true;
            this.txtResultDeductions.Size = new System.Drawing.Size(211, 19);
            this.txtResultDeductions.TabIndex = 13;
            this.txtResultDeductions.TabStop = false;
            this.txtResultDeductions.Text = "0.00";
            this.txtResultDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 604);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 26);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total Payout";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultPayout
            // 
            this.txtResultPayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultPayout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultPayout.Location = new System.Drawing.Point(159, 611);
            this.txtResultPayout.Name = "txtResultPayout";
            this.txtResultPayout.ReadOnly = true;
            this.txtResultPayout.Size = new System.Drawing.Size(211, 19);
            this.txtResultPayout.TabIndex = 13;
            this.txtResultPayout.TabStop = false;
            this.txtResultPayout.Text = "0.00";
            this.txtResultPayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 726);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 26);
            this.label15.TabIndex = 12;
            this.label15.Text = "Total Taxes";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultTaxes
            // 
            this.txtResultTaxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTaxes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTaxes.Location = new System.Drawing.Point(159, 730);
            this.txtResultTaxes.Name = "txtResultTaxes";
            this.txtResultTaxes.ReadOnly = true;
            this.txtResultTaxes.Size = new System.Drawing.Size(211, 19);
            this.txtResultTaxes.TabIndex = 13;
            this.txtResultTaxes.TabStop = false;
            this.txtResultTaxes.Text = "0.00";
            this.txtResultTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtErrors
            // 
            this.txtErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtErrors.ForeColor = System.Drawing.Color.Red;
            this.txtErrors.Location = new System.Drawing.Point(0, 760);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ReadOnly = true;
            this.txtErrors.Size = new System.Drawing.Size(1087, 58);
            this.txtErrors.TabIndex = 14;
            this.txtErrors.TabStop = false;
            // 
            // txtResultTotalPaye
            // 
            this.txtResultTotalPaye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTotalPaye.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTotalPaye.Location = new System.Drawing.Point(159, 704);
            this.txtResultTotalPaye.Name = "txtResultTotalPaye";
            this.txtResultTotalPaye.ReadOnly = true;
            this.txtResultTotalPaye.Size = new System.Drawing.Size(211, 19);
            this.txtResultTotalPaye.TabIndex = 16;
            this.txtResultTotalPaye.TabStop = false;
            this.txtResultTotalPaye.Text = "0.00";
            this.txtResultTotalPaye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 700);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 26);
            this.label16.TabIndex = 15;
            this.label16.Text = "Total PAYE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 26);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bonus";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(156, 112);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(211, 26);
            this.txtBonus.TabIndex = 38;
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
            this.txtResultBonus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBonus.Location = new System.Drawing.Point(159, 240);
            this.txtResultBonus.Name = "txtResultBonus";
            this.txtResultBonus.ReadOnly = true;
            this.txtResultBonus.Size = new System.Drawing.Size(211, 19);
            this.txtResultBonus.TabIndex = 20;
            this.txtResultBonus.TabStop = false;
            this.txtResultBonus.Text = "0.00";
            this.txtResultBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 26);
            this.label18.TabIndex = 19;
            this.label18.Text = "Bonus";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultEarnings
            // 
            this.txtResultEarnings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultEarnings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultEarnings.Location = new System.Drawing.Point(159, 264);
            this.txtResultEarnings.Name = "txtResultEarnings";
            this.txtResultEarnings.ReadOnly = true;
            this.txtResultEarnings.Size = new System.Drawing.Size(211, 19);
            this.txtResultEarnings.TabIndex = 22;
            this.txtResultEarnings.TabStop = false;
            this.txtResultEarnings.Text = "0.00";
            this.txtResultEarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 26);
            this.label19.TabIndex = 21;
            this.label19.Text = "Earnings";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkBenefitsIncluded
            // 
            this.chkBenefitsIncluded.AutoSize = true;
            this.chkBenefitsIncluded.Checked = true;
            this.chkBenefitsIncluded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBenefitsIncluded.Location = new System.Drawing.Point(452, 21);
            this.chkBenefitsIncluded.Name = "chkBenefitsIncluded";
            this.chkBenefitsIncluded.Size = new System.Drawing.Size(166, 17);
            this.chkBenefitsIncluded.TabIndex = 37;
            this.chkBenefitsIncluded.Text = "This number includes benefits";
            this.chkBenefitsIncluded.UseVisualStyleBackColor = true;
            this.chkBenefitsIncluded.CheckedChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // txtResultTotalUif
            // 
            this.txtResultTotalUif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTotalUif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTotalUif.Location = new System.Drawing.Point(159, 678);
            this.txtResultTotalUif.Name = "txtResultTotalUif";
            this.txtResultTotalUif.ReadOnly = true;
            this.txtResultTotalUif.Size = new System.Drawing.Size(211, 19);
            this.txtResultTotalUif.TabIndex = 25;
            this.txtResultTotalUif.TabStop = false;
            this.txtResultTotalUif.Text = "0.00";
            this.txtResultTotalUif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 674);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 26);
            this.label20.TabIndex = 24;
            this.label20.Text = "Total UIF";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultSecondaryRebate
            // 
            this.txtResultSecondaryRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultSecondaryRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultSecondaryRebate.Location = new System.Drawing.Point(159, 442);
            this.txtResultSecondaryRebate.Name = "txtResultSecondaryRebate";
            this.txtResultSecondaryRebate.ReadOnly = true;
            this.txtResultSecondaryRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultSecondaryRebate.TabIndex = 27;
            this.txtResultSecondaryRebate.TabStop = false;
            this.txtResultSecondaryRebate.Text = "0.00";
            this.txtResultSecondaryRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(12, 438);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 26);
            this.label21.TabIndex = 26;
            this.label21.Text = "Secondary Rebate";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultTertiaryRebate
            // 
            this.txtResultTertiaryRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTertiaryRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTertiaryRebate.Location = new System.Drawing.Point(159, 468);
            this.txtResultTertiaryRebate.Name = "txtResultTertiaryRebate";
            this.txtResultTertiaryRebate.ReadOnly = true;
            this.txtResultTertiaryRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultTertiaryRebate.TabIndex = 29;
            this.txtResultTertiaryRebate.TabStop = false;
            this.txtResultTertiaryRebate.Text = "0.00";
            this.txtResultTertiaryRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(12, 464);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 26);
            this.label22.TabIndex = 28;
            this.label22.Text = "Tertiary Rebate";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultPayeLessRebate
            // 
            this.txtResultPayeLessRebate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultPayeLessRebate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultPayeLessRebate.Location = new System.Drawing.Point(159, 497);
            this.txtResultPayeLessRebate.Name = "txtResultPayeLessRebate";
            this.txtResultPayeLessRebate.ReadOnly = true;
            this.txtResultPayeLessRebate.Size = new System.Drawing.Size(211, 19);
            this.txtResultPayeLessRebate.TabIndex = 31;
            this.txtResultPayeLessRebate.TabStop = false;
            this.txtResultPayeLessRebate.Text = "0.00";
            this.txtResultPayeLessRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 490);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 26);
            this.label23.TabIndex = 30;
            this.label23.Text = "PAYE Less Rebate";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResultEmployerUif
            // 
            this.txtResultEmployerUif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultEmployerUif.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultEmployerUif.Location = new System.Drawing.Point(159, 652);
            this.txtResultEmployerUif.Name = "txtResultEmployerUif";
            this.txtResultEmployerUif.ReadOnly = true;
            this.txtResultEmployerUif.Size = new System.Drawing.Size(211, 19);
            this.txtResultEmployerUif.TabIndex = 33;
            this.txtResultEmployerUif.TabStop = false;
            this.txtResultEmployerUif.Text = "0.00";
            this.txtResultEmployerUif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(12, 648);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(141, 26);
            this.label24.TabIndex = 32;
            this.label24.Text = "Employer UIF";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTaxYear
            // 
            this.cmbTaxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxYear.FormattingEnabled = true;
            this.cmbTaxYear.Location = new System.Drawing.Point(204, 50);
            this.cmbTaxYear.Name = "cmbTaxYear";
            this.cmbTaxYear.Size = new System.Drawing.Size(211, 21);
            this.cmbTaxYear.TabIndex = 12;
            this.cmbTaxYear.SelectedIndexChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(192, 26);
            this.label25.TabIndex = 35;
            this.label25.Text = "Tax Year";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdTotalCostToCompany
            // 
            this.rdTotalCostToCompany.Checked = true;
            this.rdTotalCostToCompany.Location = new System.Drawing.Point(373, 48);
            this.rdTotalCostToCompany.Name = "rdTotalCostToCompany";
            this.rdTotalCostToCompany.Size = new System.Drawing.Size(203, 26);
            this.rdTotalCostToCompany.TabIndex = 35;
            this.rdTotalCostToCompany.TabStop = true;
            this.rdTotalCostToCompany.Tag = "A";
            this.rdTotalCostToCompany.Text = "Specify this";
            this.rdTotalCostToCompany.UseVisualStyleBackColor = true;
            this.rdTotalCostToCompany.CheckedChanged += new System.EventHandler(this.CalculateCheckedChanged);
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(144, 26);
            this.label26.TabIndex = 37;
            this.label26.Text = "Total cost to company (TCC)";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalCostToCompany
            // 
            this.txtTotalCostToCompany.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCostToCompany.Location = new System.Drawing.Point(156, 48);
            this.txtTotalCostToCompany.Name = "txtTotalCostToCompany";
            this.txtTotalCostToCompany.Size = new System.Drawing.Size(211, 26);
            this.txtTotalCostToCompany.TabIndex = 32;
            this.txtTotalCostToCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCostToCompany.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // gbxRemuneration
            // 
            this.gbxRemuneration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRemuneration.Controls.Add(this.chkBenefitsIncluded);
            this.gbxRemuneration.Controls.Add(this.txtSalary);
            this.gbxRemuneration.Controls.Add(this.rdTotalCostToCompany);
            this.gbxRemuneration.Controls.Add(this.label1);
            this.gbxRemuneration.Controls.Add(this.label26);
            this.gbxRemuneration.Controls.Add(this.txtPayout);
            this.gbxRemuneration.Controls.Add(this.txtTotalCostToCompany);
            this.gbxRemuneration.Controls.Add(this.label2);
            this.gbxRemuneration.Controls.Add(this.rdSpecifySalary);
            this.gbxRemuneration.Controls.Add(this.rdSpecifyPayout);
            this.gbxRemuneration.Controls.Add(this.txtBonus);
            this.gbxRemuneration.Controls.Add(this.label17);
            this.gbxRemuneration.Location = new System.Drawing.Point(451, 12);
            this.gbxRemuneration.Name = "gbxRemuneration";
            this.gbxRemuneration.Size = new System.Drawing.Size(626, 192);
            this.gbxRemuneration.TabIndex = 30;
            this.gbxRemuneration.TabStop = false;
            this.gbxRemuneration.Text = "Remuneration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMedicalAid);
            this.groupBox2.Controls.Add(this.txtDependents);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 101);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medical Aid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.cmbTaxYear);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1087, 818);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxRemuneration);
            this.Controls.Add(this.txtResultEmployerUif);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtResultPayeLessRebate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtResultTertiaryRebate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtResultSecondaryRebate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtResultTotalUif);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtResultEarnings);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtResultBonus);
            this.Controls.Add(this.label18);
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
            this.Controls.Add(this.txtResultMedicalTaxCredit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtResultPrimaryRebate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultBasePaye);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResultDependents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResultMedical);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResultBasic);
            this.Controls.Add(this.label6);
            this.Name = "MainForm";
            this.Text = "SARS Thing";
            this.Load += new System.EventHandler(this.FormLoad);
            this.gbxRemuneration.ResumeLayout(false);
            this.gbxRemuneration.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdSpecifySalary;
        private System.Windows.Forms.RadioButton rdSpecifyPayout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultBasic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultMedical;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResultDependents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResultBasePaye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResultPrimaryRebate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResultMedicalTaxCredit;
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
        private System.Windows.Forms.TextBox txtResultTotalUif;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtResultSecondaryRebate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtResultTertiaryRebate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtResultPayeLessRebate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtResultEmployerUif;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbTaxYear;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rdTotalCostToCompany;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTotalCostToCompany;
        private System.Windows.Forms.GroupBox gbxRemuneration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


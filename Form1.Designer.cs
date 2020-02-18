namespace A2JeremiahMacDougall
{
    partial class frmWageCalculator
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
            this.grpEmployeeType = new System.Windows.Forms.GroupBox();
            this.rbtnSalary = new System.Windows.Forms.RadioButton();
            this.rbtnCommission = new System.Windows.Forms.RadioButton();
            this.rbtnHourly = new System.Windows.Forms.RadioButton();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grpWage = new System.Windows.Forms.GroupBox();
            this.txtCalcNetEarnings = new System.Windows.Forms.TextBox();
            this.txtCalcTax = new System.Windows.Forms.TextBox();
            this.txtCalcGrossEarnings = new System.Windows.Forms.TextBox();
            this.lblNetEarnings = new System.Windows.Forms.Label();
            this.lblLessTax = new System.Windows.Forms.Label();
            this.lblEarnings = new System.Windows.Forms.Label();
            this.lblEmpList = new System.Windows.Forms.Label();
            this.cmbEmpList = new System.Windows.Forms.ComboBox();
            this.grpEmployeeType.SuspendLayout();
            this.grpEmployeeInfo.SuspendLayout();
            this.grpWage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeType
            // 
            this.grpEmployeeType.Controls.Add(this.rbtnSalary);
            this.grpEmployeeType.Controls.Add(this.rbtnCommission);
            this.grpEmployeeType.Controls.Add(this.rbtnHourly);
            this.grpEmployeeType.Location = new System.Drawing.Point(44, 44);
            this.grpEmployeeType.Name = "grpEmployeeType";
            this.grpEmployeeType.Size = new System.Drawing.Size(541, 67);
            this.grpEmployeeType.TabIndex = 0;
            this.grpEmployeeType.TabStop = false;
            this.grpEmployeeType.Text = "Select type of employee";
            // 
            // rbtnSalary
            // 
            this.rbtnSalary.AutoSize = true;
            this.rbtnSalary.Location = new System.Drawing.Point(372, 27);
            this.rbtnSalary.Name = "rbtnSalary";
            this.rbtnSalary.Size = new System.Drawing.Size(119, 21);
            this.rbtnSalary.TabIndex = 3;
            this.rbtnSalary.Text = "Weekly Salary";
            this.rbtnSalary.UseVisualStyleBackColor = true;
            this.rbtnSalary.CheckedChanged += new System.EventHandler(this.rbtnSalary_CheckedChanged);
            // 
            // rbtnCommission
            // 
            this.rbtnCommission.AutoSize = true;
            this.rbtnCommission.Location = new System.Drawing.Point(190, 27);
            this.rbtnCommission.Name = "rbtnCommission";
            this.rbtnCommission.Size = new System.Drawing.Size(148, 21);
            this.rbtnCommission.TabIndex = 2;
            this.rbtnCommission.Text = "Commission Based";
            this.rbtnCommission.UseVisualStyleBackColor = true;
            this.rbtnCommission.CheckedChanged += new System.EventHandler(this.rbtnCommission_CheckedChanged);
            // 
            // rbtnHourly
            // 
            this.rbtnHourly.AutoSize = true;
            this.rbtnHourly.Checked = true;
            this.rbtnHourly.Location = new System.Drawing.Point(38, 27);
            this.rbtnHourly.Name = "rbtnHourly";
            this.rbtnHourly.Size = new System.Drawing.Size(102, 21);
            this.rbtnHourly.TabIndex = 1;
            this.rbtnHourly.TabStop = true;
            this.rbtnHourly.Text = "Hourly Paid";
            this.rbtnHourly.UseVisualStyleBackColor = true;
            this.rbtnHourly.CheckedChanged += new System.EventHandler(this.rbtnHourly_CheckedChanged);
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.txtWage);
            this.grpEmployeeInfo.Controls.Add(this.txtHours);
            this.grpEmployeeInfo.Controls.Add(this.txtName);
            this.grpEmployeeInfo.Controls.Add(this.lblWage);
            this.grpEmployeeInfo.Controls.Add(this.lblHoursWorked);
            this.grpEmployeeInfo.Controls.Add(this.lblName);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(44, 138);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(396, 139);
            this.grpEmployeeInfo.TabIndex = 1;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Input the employee\'s information";
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(161, 105);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(217, 22);
            this.txtWage.TabIndex = 6;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(161, 62);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(217, 22);
            this.txtHours.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(12, 110);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(94, 17);
            this.lblWage.TabIndex = 0;
            this.lblWage.Text = "Hourly Wage:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(12, 68);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(103, 17);
            this.lblHoursWorked.TabIndex = 0;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(446, 144);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(139, 29);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(446, 200);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(139, 29);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(447, 248);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(139, 29);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // grpWage
            // 
            this.grpWage.Controls.Add(this.txtCalcNetEarnings);
            this.grpWage.Controls.Add(this.txtCalcTax);
            this.grpWage.Controls.Add(this.txtCalcGrossEarnings);
            this.grpWage.Controls.Add(this.lblNetEarnings);
            this.grpWage.Controls.Add(this.lblLessTax);
            this.grpWage.Controls.Add(this.lblEarnings);
            this.grpWage.Location = new System.Drawing.Point(47, 299);
            this.grpWage.Name = "grpWage";
            this.grpWage.Size = new System.Drawing.Size(538, 142);
            this.grpWage.TabIndex = 3;
            this.grpWage.TabStop = false;
            this.grpWage.Text = "Calculated wage";
            // 
            // txtCalcNetEarnings
            // 
            this.txtCalcNetEarnings.Location = new System.Drawing.Point(135, 94);
            this.txtCalcNetEarnings.Name = "txtCalcNetEarnings";
            this.txtCalcNetEarnings.ReadOnly = true;
            this.txtCalcNetEarnings.Size = new System.Drawing.Size(389, 22);
            this.txtCalcNetEarnings.TabIndex = 1;
            this.txtCalcNetEarnings.TabStop = false;
            // 
            // txtCalcTax
            // 
            this.txtCalcTax.Location = new System.Drawing.Point(135, 58);
            this.txtCalcTax.Name = "txtCalcTax";
            this.txtCalcTax.ReadOnly = true;
            this.txtCalcTax.Size = new System.Drawing.Size(389, 22);
            this.txtCalcTax.TabIndex = 1;
            this.txtCalcTax.TabStop = false;
            // 
            // txtCalcGrossEarnings
            // 
            this.txtCalcGrossEarnings.Location = new System.Drawing.Point(135, 22);
            this.txtCalcGrossEarnings.Name = "txtCalcGrossEarnings";
            this.txtCalcGrossEarnings.ReadOnly = true;
            this.txtCalcGrossEarnings.Size = new System.Drawing.Size(389, 22);
            this.txtCalcGrossEarnings.TabIndex = 10;
            this.txtCalcGrossEarnings.TabStop = false;
            // 
            // lblNetEarnings
            // 
            this.lblNetEarnings.AutoSize = true;
            this.lblNetEarnings.Location = new System.Drawing.Point(12, 99);
            this.lblNetEarnings.Name = "lblNetEarnings";
            this.lblNetEarnings.Size = new System.Drawing.Size(94, 17);
            this.lblNetEarnings.TabIndex = 0;
            this.lblNetEarnings.Text = "Net Earnings:";
            // 
            // lblLessTax
            // 
            this.lblLessTax.AutoSize = true;
            this.lblLessTax.Location = new System.Drawing.Point(12, 58);
            this.lblLessTax.Name = "lblLessTax";
            this.lblLessTax.Size = new System.Drawing.Size(69, 17);
            this.lblLessTax.TabIndex = 0;
            this.lblLessTax.Text = "Less Tax:";
            // 
            // lblEarnings
            // 
            this.lblEarnings.AutoSize = true;
            this.lblEarnings.Location = new System.Drawing.Point(12, 22);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(110, 17);
            this.lblEarnings.TabIndex = 0;
            this.lblEarnings.Text = "Gross Earnings:";
            // 
            // lblEmpList
            // 
            this.lblEmpList.AutoSize = true;
            this.lblEmpList.Location = new System.Drawing.Point(59, 461);
            this.lblEmpList.Name = "lblEmpList";
            this.lblEmpList.Size = new System.Drawing.Size(81, 17);
            this.lblEmpList.TabIndex = 4;
            this.lblEmpList.Text = "Employees:";
            // 
            // cmbEmpList
            // 
            this.cmbEmpList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpList.FormattingEnabled = true;
            this.cmbEmpList.Location = new System.Drawing.Point(187, 458);
            this.cmbEmpList.Name = "cmbEmpList";
            this.cmbEmpList.Size = new System.Drawing.Size(384, 24);
            this.cmbEmpList.TabIndex = 10;
            this.cmbEmpList.SelectedIndexChanged += new System.EventHandler(this.cmbEmpList_SelectedIndexChanged);
            // 
            // frmWageCalculator
            // 
            this.AcceptButton = this.btn_Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(644, 563);
            this.Controls.Add(this.cmbEmpList);
            this.Controls.Add(this.lblEmpList);
            this.Controls.Add(this.grpWage);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Controls.Add(this.grpEmployeeType);
            this.Name = "frmWageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculator";
         
            this.grpEmployeeType.ResumeLayout(false);
            this.grpEmployeeType.PerformLayout();
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.grpWage.ResumeLayout(false);
            this.grpWage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeType;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RadioButton rbtnSalary;
        private System.Windows.Forms.RadioButton rbtnCommission;
        private System.Windows.Forms.RadioButton rbtnHourly;
        private System.Windows.Forms.GroupBox grpWage;
        private System.Windows.Forms.TextBox txtCalcNetEarnings;
        private System.Windows.Forms.TextBox txtCalcTax;
        private System.Windows.Forms.TextBox txtCalcGrossEarnings;
        private System.Windows.Forms.Label lblNetEarnings;
        private System.Windows.Forms.Label lblLessTax;
        private System.Windows.Forms.Label lblEarnings;
        private System.Windows.Forms.Label lblEmpList;
        private System.Windows.Forms.ComboBox cmbEmpList;
    }
}


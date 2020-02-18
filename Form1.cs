using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A2JeremiahMacDougall
{
    public partial class frmWageCalculator : Form
    {
        List<Employee> employeesList = new List<Employee>();
        public frmWageCalculator()
        {
            InitializeComponent();
        }



        private void rbtnCommission_CheckedChanged(object sender, EventArgs e)
        {
            lblHoursWorked.Text = "Gross Sales:";
            lblWage.Text = "Commission Rate %:";
            lblWage.Visible = true;
            txtWage.Visible = true;
            // ClearForm();
        }

        private void rbtnSalary_CheckedChanged(object sender, EventArgs e)
        {
            lblHoursWorked.Text = "Weekly Salary:";
            lblWage.Visible = false;
            txtWage.Visible = false;
            // ClearForm();
        }

        private void rbtnHourly_CheckedChanged(object sender, EventArgs e)
        {
            lblWage.Visible = true;
            txtWage.Visible = true;
            lblHoursWorked.Text = "Hours Worked:";
            lblWage.Text = "Hourly Wage:";
            // ClearForm();
        }

        private void Display(Employee emp)
        {
            double _Tax = 0;
            double _NetEarnings = 0;

            _Tax = emp.Tax;
            _NetEarnings = emp.NetEarnings;
            txtCalcGrossEarnings.Text = emp.GrossEarnings.ToString("C2");
            txtCalcTax.Text = _Tax.ToString("C2");
            txtCalcNetEarnings.Text = _NetEarnings.ToString("C2");
            txtName.Text = emp.Name;

            if (emp.TypeOfEmployee == EmployeeType.Hourly)
            {
                // get all the hourly info  hours and wage
                rbtnHourly.Checked = true;

                // THE NEXT LINE IS THE SOLUTION!!!

                HourlyEmployee hrEmp = emp as HourlyEmployee;
                txtWage.Text = hrEmp.HourlyWage.ToString();
                txtHours.Text = hrEmp.HoursWorked.ToString();


            }
            else if (emp.TypeOfEmployee == EmployeeType.Commission)
            {
                rbtnCommission.Checked = true;
                CommissionEmployee commEmp = emp as CommissionEmployee;
                // now read the values back into the text fields
                txtHours.Text = commEmp.GrossSales.ToString();
                txtWage.Text = commEmp.CommissionRate.ToString();
            }
            else  // this must be a salaried employee by elimination
            {
                rbtnSalary.Checked = true;
                SalariedEmployee salEmp = emp as SalariedEmployee;
                // now get the values and store it on the form
                txtHours.Text = salEmp.Salary.ToString();
            }

        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {

            string _EmployeeName = txtName.Text;

            // before you run the code below, add an if statement here to check if the name already lists in the generic list 
            if (!cmbEmpList.Items.Contains(_EmployeeName) && _EmployeeName != "")
            {
                /* check the employee type from the button at the top.
             * setup some sort of if then else to create the appropriate Object based on the type, and then fill in the proper data.  
             * Drop the thing into the list */

                // IMPORTANT  - ADD A SAFETY CHECK IN HERE TO ENSURE THAT AN INVALID VALUE SUCH AS TEXT IN A NUMERIC FIELD IS CAUGHT!!

                int ii; double dd;

                bool _CheckHours = int.TryParse(txtHours.Text, out ii);
                bool _CheckWage = double.TryParse(txtWage.Text, out dd);


                if (rbtnSalary.Checked && int.TryParse(txtHours.Text, out ii))
                {
                    Console.WriteLine("User selected calculate, Salaryselected");
                    if (ii < 0)
                    {
                        // put a message here that hours are out of range
                        MessageBox.Show("The value entered for salary is not valid.");
                    }
                    else
                    {
                        // for this next bunch of variables, consider whether or not there is duplication and where to put the code; 

                        Employee employee = new SalariedEmployee(_EmployeeName, EmployeeType.Salaried, Double.Parse(txtHours.Text));
                        cmbEmpList.Items.Add(employee.Name);
                        // now add the object to the generic list
                        employeesList.Add(employee);

                        Display(employee);
                    }

                }
                else if (rbtnCommission.Checked && int.TryParse(txtHours.Text, out ii) && double.TryParse(txtWage.Text, out dd))
                {
                    Console.WriteLine("User selected calculate, Commission  selected");
                    double _CommissionRate = 0;
                    _CommissionRate = Double.Parse(txtWage.Text);

                    if (ii < 0 || _CommissionRate < 0)
                    {
                        // put a message here that hours are out of range
                        MessageBox.Show("The number of hours/commission rate is out of range.");
                    }
                    else
                    {
                        Employee employee = new CommissionEmployee(_EmployeeName, EmployeeType.Commission, Double.Parse(txtHours.Text), _CommissionRate);
                        cmbEmpList.Items.Add(employee.Name);
                        // now add the object to the generic list
                        employeesList.Add(employee);

                        Display(employee);
                    }

                }
                else if (rbtnHourly.Checked && int.TryParse(txtHours.Text, out ii) && double.TryParse(txtWage.Text, out dd))
                {

                    Console.WriteLine("User selected calculate, hourly  selected");

                    if (ii < 0 || ii > 80 || dd < 0)
                    {
                        // put a message here that hours are out of range
                        MessageBox.Show("The number of hours / wage is out of range.");
                    }
                    else
                    {
                        Employee employee = new HourlyEmployee(_EmployeeName, EmployeeType.Hourly, int.Parse(txtHours.Text), double.Parse(txtWage.Text));

                        cmbEmpList.Items.Add(employee.Name);
                        // now add the object to the generic list
                        employeesList.Add(employee);
                        Display(employee);
                    }

                }
                else
                    MessageBox.Show("Text was entered but a number was expected.");
            } // end contains check
            else
                MessageBox.Show("The name cannot be left blank, or already exists!");

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearForm()
        {
            // clear all items from the form but not lists, that way if the user toggles radio buttons for a new user, they don't lose their lists

            txtName.Text = "";
            txtHours.Text = "";
            txtWage.Text = "";
            txtCalcGrossEarnings.Text = "";
            txtCalcNetEarnings.Text = "";
            txtCalcTax.Text = "";
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();

            // if later on we wanted to clear the list of employees, there is where the code would be
        }

        private void cmbEmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // first, find the selection in the List
            string name = cmbEmpList.Text;

            Console.WriteLine("The selected item is " + cmbEmpList.SelectedIndex + " " + name);

            // and then load the object from the list and place the values into the text fields on the form

            Employee emp = employeesList.Find(item => item.Name == name);

            Console.WriteLine($"This is the object:{emp.Name} {emp.TypeOfEmployee}");

            Display(emp);

        }
    }
}

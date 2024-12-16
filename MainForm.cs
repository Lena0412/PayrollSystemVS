using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jones_CourseProject_part2_updated
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // add item to the employee listbox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if the input form was cancelled
                if (result == DialogResult.Cancel)
                    return; // end the method

                // get the user's input and create employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                int lifeIns = int.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = int.Parse(frmInput.VacationDaysTextBox.Text);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(fName, lName, ssn, hireDate, ben);

                // add the employee object to the employee listbox
                EmployeesListBox.Items.Add(emp);

                // write all data to the file
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";
            
            StreamWriter sw = new StreamWriter(filename);
            
            foreach (Employee emp in EmployeesListBox.Items)
            {
                sw.WriteLine(emp.FirstName + ','
                    + emp.LastName + ','
                    + emp.SSN + ',' 
                    + emp.HireDate.ToShortDateString() + ','
                    + emp.BenefitsEmp.HealthInsurance + ','
                    + emp.BenefitsEmp.LifeInsurance + ','
                    + emp.BenefitsEmp.Vacation);
            }

            sw.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if( itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // clear the employee listbox
            EmployeesListBox.Items.Clear();

            // read employees from the file
            string filename = "Employees.csv";
            StreamReader sr = new StreamReader(filename);

            while( sr.Peek() > -1 )
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                string healthIns = parts[4];
                int lifeIns = int.Parse(parts[5]);
                int vacation = int.Parse(parts[6]);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(firstName, lastName, ssn, hireDate, ben);
                
                EmployeesListBox.Items.Add(emp);
            }

            sr.Close();
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            // get the selected employee object
            Employee emp = EmployeesListBox.SelectedItem as Employee;

            // show the input/update form with the employee info
            InputForm frmUpdate = new InputForm();
            frmUpdate.FirstNameTextBox.Text = emp.FirstName;
            frmUpdate.LastNameTextBox.Text = emp.LastName;
            frmUpdate.SSNTextBox.Text = emp.SSN;
            frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
            frmUpdate.HealthInsuranceTextBox.Text = emp.BenefitsEmp.HealthInsurance;
            frmUpdate.LifeInsuranceTextBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
            frmUpdate.VacationDaysTextBox.Text = emp.BenefitsEmp.Vacation.ToString();
            DialogResult result = frmUpdate.ShowDialog();

            // if cancelled, stop the method
            if (result == DialogResult.Cancel)
                return; // end the method

            // delete the selected object
            int position = EmployeesListBox.SelectedIndex;
            EmployeesListBox.Items.RemoveAt(position);

            // create new employee using the updated information
            Employee newEmp = new Employee();
            newEmp.FirstName = frmUpdate.FirstNameTextBox.Text;
            newEmp.LastName = frmUpdate.LastNameTextBox.Text;
            newEmp.SSN = frmUpdate.SSNTextBox.Text;
            newEmp.HireDate = DateTime.Parse(frmUpdate.HireDateTextBox.Text);
            newEmp.BenefitsEmp.HealthInsurance = frmUpdate.HealthInsuranceTextBox.Text;
            newEmp.BenefitsEmp.LifeInsurance = int.Parse(frmUpdate.LifeInsuranceTextBox.Text);
            newEmp.BenefitsEmp.Vacation = int.Parse(frmUpdate.VacationDaysTextBox.Text);

            // add the new employee to the listbox
            EmployeesListBox.Items.Add(newEmp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusLibrary.Data_Access_Layer;
using BusLibrary.Data_Transfer_Layer;


namespace BusSystemUI
{
    /// <summary>
    /// Interaction logic for EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window, IEditWindow
    {
        /// <summary>
        /// Biến dùng để lưu dữ liệu của người dùng chọn
        /// nhằm chuyển dữ liệu cần thiết (như Id) từ constructor lên event
        /// </summary>
        private EmployeeModel employee;

        /// <summary>
        /// Constructor với tham số là một EmployeeModel
        /// được convert từ một hàng mà user chọn trong List View
        /// </summary>
        /// <param name="selectedEmployee"></param>
        public EditEmployeeWindow(EmployeeModel selectedEmployee)
        {
            InitializeComponent();

            employee = selectedEmployee;

            WireUpFields();
        }

        public void WireUpFields()
        {
            idTextBox.Text = employee.EmployeeId;
            firstNameTextBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            ageTextBox.Text = employee.Age.ToString();
            startDateTextBox.Text = employee.StartDate.ToString();
            baseSalaryTextBox.Text = employee.BaseSalary.ToString();
            currentSalaryTextBox.Text = employee.CurrentSalary.ToString();
            dateOfBirthTextBox.Text = employee.DateOfBirth.ToString();
            emailTextBox.Text = employee.Email;
            sexTextBox.Text = employee.Sex;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm editing this employee ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                EmployeeModel em = new EmployeeModel();

                em.EmployeeId = idTextBox.Text;
                em.FirstName = firstNameTextBox.Text;
                em.LastName = lastNameTextBox.Text;

                // Age must > 0
                if (int.TryParse(ageTextBox.Text, out int age))
                {
                    em.Age = age;
                }

                if (DateTime.TryParse(startDateTextBox.Text, out DateTime startDate))
                {
                    em.StartDate = startDate;
                }

                if (int.TryParse(baseSalaryTextBox.Text, out int baseSalary))
                {
                    em.BaseSalary = baseSalary;
                }

                if (int.TryParse(currentSalaryTextBox.Text, out int currentSalary))
                {
                    em.CurrentSalary = currentSalary;
                }

                em.DateOfBirth = dateOfBirthTextBox.Text;
                em.Email = emailTextBox.Text;
                em.Sex = sexTextBox.Text;

                EmployeeDAO.Instance.EditEmployee(em, employee.EmployeeId);

                this.Close();
            }
        }
    }
}

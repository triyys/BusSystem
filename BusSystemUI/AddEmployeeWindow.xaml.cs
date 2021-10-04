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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm adding this employee ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                EmployeeModel em = new EmployeeModel();

                em.EmployeeId = idTextBox.Text;
                em.FirstName = firstNameTextBox.Text;
                em.LastName = lastNameTextBox.Text;

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

                EmployeeDAO.Instance.AddListEmployee(em);

                this.Close();
            }
        }

        private bool ValidateForm()
        {
            // TODO - Validate text boxes

            return true;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

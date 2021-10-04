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
    /// Interaction logic for AddRouteWindow.xaml
    /// </summary>
    public partial class AddRouteWindow : Window
    {
        public AddRouteWindow()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm adding this route ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                RouteModel r = new RouteModel();

                r.RouteId = routeIdTextBox.Text;
                r.EmployeeId = employeeIdTextBox.Text;
                r.LastName = lastNameTextBox.Text;
                r.FirstName = firstNameTextBox.Text;
                r.Email = emailTextBox.Text;

                if (int.TryParse(distanceTextBox.Text, out int distance))
                {
                    r.Distance = distance;
                }

                RouteDAO.Instance.AddListRoute(r);

                this.Close();
            }
        }
    }
}

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
    /// Interaction logic for EditRouteWindow.xaml
    /// </summary>
    public partial class EditRouteWindow : Window, IEditWindow
    {
        /// <summary>
        /// Biến dùng để lưu dữ liệu của người dùng chọn
        /// nhằm chuyển dữ liệu cần thiết (như Id) từ constructor lên event
        /// </summary>
        private RouteModel route;

        /// <summary>
        /// Constructor với tham số là một RouteModel
        /// được convert từ một hàng mà user chọn trong List View
        /// </summary>
        /// <param name="selectedRoute"></param>
        public EditRouteWindow(RouteModel selectedRoute)
        {
            InitializeComponent();

            route = selectedRoute;

            WireUpFields();
        }

        public void WireUpFields()
        {
            routeIdTextBox.Text = route.RouteId;
            distanceTextBox.Text = route.Distance.ToString();
            employeeIdTextBox.Text = route.EmployeeId;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm editing this employee ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                RouteModel r = new RouteModel();

                r.RouteId = routeIdTextBox.Text;
                r.EmployeeId = employeeIdTextBox.Text;

                if (int.TryParse(distanceTextBox.Text, out int distance))
                {
                    r.Distance = distance;
                }
                
                RouteDAO.Instance.EditRoute(r, route.RouteId);

                this.Close();
            }
        }
    }
}

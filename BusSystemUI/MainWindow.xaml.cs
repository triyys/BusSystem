using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusLibrary.Data_Access_Layer;
using BusLibrary.Data_Transfer_Layer;

namespace BusSystemUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string notSelectedError = "Hãy chọn một hàng để tiếp tục !!";

        public MainWindow()
        {
            InitializeComponent();

            DataEstablishment.Instance.Establish();

            WireUpModels();
        }

        public void WireUpModels()
        {
            LoadEmployees();

            LoadBuses();

            LoadRoutes();

            LoadTickets();
        }

        #region EMPLOYEE
        private void LoadEmployees()
        {
            List<EmployeeModel> employees = EmployeeDAO.Instance.GetListAllEmployee();
            Employee_List_View.ItemsSource = employees;
        }

        private void SearchEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = (firstNameTextbox.Text == "" ? null : firstNameTextbox.Text);
            string lastName = (lastNameTextBox.Text == "" ? null : lastNameTextBox.Text);
            string employeeId = (codeTextBox.Text == "" ? null : codeTextBox.Text);
            int age;
            int salary;

            if (Int32.TryParse(ageTextBox.Text, out age))
            {
                ;
            }
            else
            {
                if (ageTextBox.Text != "")
                {
                    MessageBox.Show("Invalid age, must be an integer number");
                }

                age = -1;
            }

            if (Int32.TryParse(salaryTextBox.Text, out salary))
            {
                ;
            }
            else
            {
                if (salaryTextBox.Text != "")
                {
                    MessageBox.Show("Invalid salary, must be an integer number");
                }

                salary = -1;
            }

            List<EmployeeModel> employees = EmployeeDAO.Instance.FindEmployees(employeeId, firstName, lastName, age, salary);
            Employee_List_View.ItemsSource = employees;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow wd = new AddEmployeeWindow();
            wd.ShowDialog();
            LoadEmployees();
        }

        private void LoadEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
            MessageBox.Show("Loaded succesfully!!");
        }

        private void DeleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selection ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                List<EmployeeModel> employees = new List<EmployeeModel>();

                for (int i = 0; i < Employee_List_View.SelectedItems.Count; i++)
                {
                    employees.Add((EmployeeModel)Employee_List_View.SelectedItems[i]);
                }

                EmployeeDAO.Instance.DeleteListEmployee(employees);

                LoadEmployees();
            }
        }

        private void EditEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel selectedEmployee = (EmployeeModel)Employee_List_View.SelectedItem;

            if (selectedEmployee != null)
            {
                EditEmployeeWindow wd = new EditEmployeeWindow(selectedEmployee);

                wd.ShowDialog();

                LoadEmployees();
            }
            else
            {
                MessageBox.Show(notSelectedError);
            }
        }
        #endregion

        #region BUS
        private void LoadBuses()
        {
            List<BusModel> buses = BusDAO.Instance.GetListAllBus();
            Bus_List_View.ItemsSource = buses;
        }

        private void SearchBusButton_Click(object sender, RoutedEventArgs e)
        {
            string LPN = (licensedPlateNoTextbox.Text == "" ? null : licensedPlateNoTextbox.Text);
            string TOB = (typeOfBusTextBox.Text == "" ? null : typeOfBusTextBox.Text);
            int NOS;
            if (Int32.TryParse(NoOfSeatsTextBox.Text, out NOS))
            {
                ;
            }
            else
            {
                if (ageTextBox.Text != "")
                {
                    MessageBox.Show("Invalid age, must be an integer number");
                }
                NOS = -1;
            }
            List<BusModel> buses = BusDAO.Instance.FindBus(TOB, LPN, NOS);
            Bus_List_View.ItemsSource = buses;
        }

        private void AddBusButton_Click(object sender, RoutedEventArgs e)
        {
            AddBusWindow wd = new AddBusWindow();
            wd.ShowDialog();
            LoadBuses();
        }

        private void LoadBusButton_Click(object sender, RoutedEventArgs e)
        {
            LoadBuses();
            MessageBox.Show("Loaded succesfully!!");
        }

        private void DeleteBusButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selection ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                List<BusModel> buss = new List<BusModel>();
                for (int i = 0; i < Bus_List_View.SelectedItems.Count; i++)
                {
                    buss.Add((BusModel)Bus_List_View.SelectedItems[i]);
                }
                BusDAO.Instance.DeleteListEmployee(buss);
                LoadBuses();
            }
        }

        private void EditBusButton_Click(object sender, RoutedEventArgs e)
        {
            BusModel selectedBus = (BusModel)Bus_List_View.SelectedItem;

            if (selectedBus != null)
            {
                EditBusWindow wd = new EditBusWindow(selectedBus);

                wd.ShowDialog();

                LoadBuses();
            }
            else
            {
                MessageBox.Show(notSelectedError);
            }
        }
        #endregion

        #region ROUTE
        private void LoadRoutes()
        {
            List<RouteModel> routes = RouteDAO.Instance.GetListAllRoute();
            Route_List_View.ItemsSource = routes;
        }

        private void SearchRouteButton_Click(object sender, RoutedEventArgs e)
        {
            int distance;

            if (Int32.TryParse(routeDistanceTextBox.Text, out distance))
            {
                ;
            }
            else
            {
                if (routeDistanceTextBox.Text != "")
                {
                    MessageBox.Show("Invalid distance, must be an integer number");
                }

                distance = 0;
            }

            List<RouteModel> routes = RouteDAO.Instance.FindRoutes(distance);
            Route_List_View.ItemsSource = routes;
        }

        private void AddRouteButton_Click(object sender, RoutedEventArgs e)
        {
            AddRouteWindow wd = new AddRouteWindow();
            wd.ShowDialog();
            LoadRoutes();
        }

        private void LoadRouteButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRoutes();
            MessageBox.Show("Loaded successfully!!");
        }

        private void DeleteRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selection ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                List<RouteModel> routes = new List<RouteModel>();
                for (int i = 0; i < Route_List_View.SelectedItems.Count; i++)
                {
                    routes.Add((RouteModel)Route_List_View.SelectedItems[i]);
                }
                RouteDAO.Instance.DeleteListRoute(routes);
                LoadRoutes();
            }
        }

        private void EditRouteButton_Click(object sender, RoutedEventArgs e)
        {
            RouteModel selectedRoute = (RouteModel)Route_List_View.SelectedItem;

            if (selectedRoute != null)
            {
                EditRouteWindow wd = new EditRouteWindow(selectedRoute);

                wd.ShowDialog();

                LoadRoutes();
            }
            else
            {
                MessageBox.Show(notSelectedError);
            }
        }
        #endregion

        #region TICKET
        public void LoadTickets(bool __DESC = false)
        {
            if (__DESC == false)
            {
                DataContext = this;
                List<TicketModel> tickets = TicketDAO.Instance.GetListAllTicket();
                Ticket_List_View.ItemsSource = tickets;
            }
            else
            {
                DataContext = this;
                List<TicketModel> tickets = TicketDAO.Instance.GetListAllTicketDESC();
                Ticket_List_View.ItemsSource = tickets;
            }
        }

        private void SearchTicketButton_Click(object sender, RoutedEventArgs e)
        {
            string ticketId = (ticketIdTextBox.Text == "" ? null : ticketIdTextBox.Text);
            string type = (typeTicketTextBox.Text == "" ? null : typeTicketTextBox.Text);
            string routeId = (routeIdTextBox.Text == "" ? null : routeIdTextBox.Text);
            string paymentId = (paymentIdTextBox.Text == "" ? null : paymentIdTextBox.Text);
            int price, tripNo;
            if (Int32.TryParse(priceTextBox.Text, out price))
            {
                ;
            }
            else
            {
                if (priceTextBox.Text != "")
                {
                    MessageBox.Show("Invalid price, must be an integer number");
                }
                price = -1;
            }

            if (Int32.TryParse(tripNoTextBox.Text, out tripNo))
            {
                ;
            }
            else
            {
                if (tripNoTextBox.Text != "")
                {
                    MessageBox.Show("Invalid trip no., must be an integer number");
                }
                tripNo = -1;
            }
            //string msg = "search " + ticketId + " " + type + " " + price.ToString() + " " + routeId + " " + tripNo.ToString() + " " + paymentId + ".";
            //MessageBox.Show(msg);

            List<TicketModel> res = TicketDAO.Instance.LookForTicket(ticketId, type, price, routeId, tripNo, paymentId);
            Ticket_List_View.ItemsSource = res;
        }

        private void AddTicketButton_Click(object sender, RoutedEventArgs e)
        {
            AddTicketWindow wd = new AddTicketWindow();
            wd.ShowDialog();
            LoadTickets();
        }

        private void LoadTicketButton_Click(object sender, RoutedEventArgs e)
        {
            LoadTickets();
            MessageBox.Show("Reloaded successfully!!");
        }

        private void DeleteTicketButton_Click(object sender, RoutedEventArgs e)
        {
            if (Ticket_List_View.SelectedItems.Count == 0)
            {
                MessageBox.Show("You haven't choose any ticket yet. Please try again!");
            }
            else
            if (MessageBox.Show("Do you want to delete the selection?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                List<TicketModel> tickets = new List<TicketModel>();
                for (int i = 0; i < Ticket_List_View.SelectedItems.Count; i++)
                {
                    tickets.Add((TicketModel)Ticket_List_View.SelectedItems[i]);
                }
                TicketDAO.Instance.DeleteListTicket(tickets);
                LoadTickets();
            }
        }

        private void EditTicketButton_Click(object sender, RoutedEventArgs e)
        {
            TicketModel selectedTicket = (TicketModel)Ticket_List_View.SelectedItem;

            if (selectedTicket != null)
            {
                EditTicketWindow wd = new EditTicketWindow(selectedTicket);

                wd.ShowDialog();

                LoadTickets();
            }
            else
            {
                MessageBox.Show(notSelectedError);
            }
        }
        #endregion
    }
}

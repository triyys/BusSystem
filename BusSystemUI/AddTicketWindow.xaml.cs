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
    public partial class AddTicketWindow : Window
    {
        public AddTicketWindow()
        {
            InitializeComponent();
            
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private bool checkInput(string _ticketId, string _paymentId, string _type, string _routeId)
        {
            if (_ticketId.Length > 10 || _paymentId.Length > 11 || _type.Length > 1 || _routeId.Length > 2)
                return false;
            return true;
        }


        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!checkInput(addTicketIdTextBox.Text, addPaymentIdTicketTextBox.Text, addTypeTicketTextBox.Text, addRouteIdTicketTextBox.Text))
            {
                MessageBox.Show("Warning: Please check the format of the input again!!!" +
                    "\nticket_id: varchar(10)\ntype: varchar(1)\nroute_id: varchar(2)\npayment_id: varchar(11)");
  
            }
            else 
            if (MessageBox.Show("Do you want to confirm adding this ticket?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TicketModel t = new TicketModel();

                t.TicketId = addTicketIdTextBox.Text;
                t.Price = Int32.Parse(addPriceTicketTextBox.Text);
                t.TripNo = Int32.Parse(addTripNoTicketTextBox.Text);
                t.RouteId = addRouteIdTicketTextBox.Text;
                t.Type = addTypeTicketTextBox.Text;
                t.PaymentId = addPaymentIdTicketTextBox.Text;

                TicketDAO.Instance.AddListTicket(t);

                this.Close();
            }
        }
    }
}

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
  
    public partial class EditTicketWindow : Window, IEditWindow
    {
        private TicketModel ticket;

        public EditTicketWindow(TicketModel selectedTicket)
        {
            InitializeComponent();

            ticket = selectedTicket;

            WireUpFields();
        }

        public void WireUpFields()
        {
            updateTicketIdTextBox.Text = ticket.TicketId;
            updatePaymentIdTicketTextBox.Text = ticket.PaymentId;
            updateRouteIdTicketTextBox.Text = ticket.RouteId;
            updateTypeTicketTextBox.Text = ticket.Type;
            updateTripNoTicketTextBox.Text = ticket.TripNo.ToString();
            updatePriceTicketTextBox.Text = ticket.Price.ToString();
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
            if (!checkInput(updateTicketIdTextBox.Text, updatePaymentIdTicketTextBox.Text, updateTypeTicketTextBox.Text, updateRouteIdTicketTextBox.Text))
            {
                MessageBox.Show("Warning: Please check the format of the input again!!!" +
                    "\nticket_id: varchar(10)\ntype: varchar(1)\nroute_id: varchar(2)\npayment_id: varchar(11)");
            }
            else
            if (MessageBox.Show("Do you want to confirm editing this ticket?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TicketModel t = new TicketModel();

                t.PaymentId = updatePaymentIdTicketTextBox.Text;
                t.RouteId = updateRouteIdTicketTextBox.Text;
                t.TicketId = updateTicketIdTextBox.Text;
                t.Type = updateTypeTicketTextBox.Text;

                t.Price = Int32.Parse(updatePriceTicketTextBox.Text);
                t.TripNo = Int32.Parse(updateTripNoTicketTextBox.Text);

                this.Close();
                TicketDAO.Instance.UpdateTicket(t, ticket.TicketId);
            }
        }
    }
}

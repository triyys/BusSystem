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
    /// Interaction logic for AddBusWindow.xaml
    /// </summary>
    public partial class AddBusWindow : Window
    {
        public AddBusWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm adding this bus ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BusModel b = new BusModel();

                b.TypeOfBus = typeOfBusTextBox.Text;
                b.LicensePlateNo = license_plateTextBox.Text;

                if (int.TryParse(seatnoTextBox.Text, out int seatNo))
                {
                    b.NumberOfSeats = seatNo;
                }

                BusDAO.Instance.AddListBus(b);

                this.Close();
            }
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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
    /// Interaction logic for EditBusWindow.xaml
    /// </summary>
    public partial class EditBusWindow : Window, IEditWindow
    {
        /// <summary>
        /// Biến dùng để lưu dữ liệu của người dùng chọn
        /// nhằm chuyển dữ liệu cần thiết (như Id) từ constructor lên event
        /// </summary>
        private BusModel bus;

        /// <summary>
        /// Constructor với tham số là một BusModel
        /// được convert từ một hàng mà user chọn trong List View
        /// </summary>
        /// <param name="selectedBus"></param>
        public EditBusWindow(BusModel selectedBus)
        {
            InitializeComponent();

            bus = selectedBus;

            WireUpFields();
        }

        public void WireUpFields()
        {
            licenseNoTextBox.Text = bus.LicensePlateNo;
            typeBusTextBox.Text = bus.TypeOfBus;
            NoSeatTextBox.Text = bus.NumberOfSeats.ToString();
        }

        private void returnBusButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitBusButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm editing this bus ?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BusModel b = new BusModel();

                b.LicensePlateNo = licenseNoTextBox.Text;
                b.TypeOfBus = typeBusTextBox.Text;

                if (int.TryParse(NoSeatTextBox.Text, out int noSeat))
                {
                    b.NumberOfSeats = noSeat;
                }

                BusDAO.Instance.EditBus(b, bus.LicensePlateNo);

                this.Close();
            }
        }
    }
}

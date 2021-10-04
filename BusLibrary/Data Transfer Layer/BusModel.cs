using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLibrary.Data_Transfer_Layer
{
    public class BusModel
    {
        public BusModel() { }

        public BusModel(string typeOfBus, string licensePlateNo, int numberOfSeats)
        {
            TypeOfBus = typeOfBus;
            LicensePlateNo = licensePlateNo;
            NumberOfSeats = numberOfSeats;
        }

        public BusModel(DataRow row)
        {
            TypeOfBus = row["type_of_bus"].ToString();
            LicensePlateNo = row["license_plate_no"].ToString();
            NumberOfSeats = (int)row["number_of_seats"];
        }

        private string typeOfBus;
        private string licensePlateNo;
        private int numberOfSeats;
        public string TypeOfBus{ get => typeOfBus; set => typeOfBus = value; }
        public string LicensePlateNo { get => licensePlateNo; set => licensePlateNo = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
} 
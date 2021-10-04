using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BusLibrary.Data_Transfer_Layer;

namespace BusLibrary.Data_Access_Layer
{
    public class BusDAO
    {
        private static BusDAO instance;

        public static BusDAO Instance
        {
            get { if (instance == null) instance = new BusDAO(); return instance; }
            private set => instance = value;
        }

        private BusDAO() { }

        public List<BusModel> GetListAllBus()
        {
            List<BusModel> output = new List<BusModel>();

            string query = "CALL bus_system.spBus_GetAll();";

            DataTable table = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                BusModel bus = new BusModel(row);

                output.Add(bus);
            }

            return output;
        }

        public List<BusModel> FindBus(string typeOfBus, string licensedPlateNo, int numberOfSeats = -1)
        {
            List<BusModel> BusResult = new List<BusModel>();
            string query = "SELECT * FROM BUS";
            if (!(typeOfBus == null && licensedPlateNo == null && numberOfSeats == -1 ))
            {
                query += " WHERE ";
                if (typeOfBus != null)
                {
                    string additional_query = "type_of_bus = '" + typeOfBus + "'";
                    query += additional_query;
                    query += " AND ";
                }
                if (licensedPlateNo != null)
                {
                    string additional_query = "license_plate_no = '" + licensedPlateNo + "'";
                    query += additional_query;
                    query += " AND ";
                }
                if (numberOfSeats != -1)
                {
                    string additional_query = "number_of_seats = " + numberOfSeats.ToString();
                    query += additional_query;
                    query += " AND ";
                }
                // Remove the final " AND "
                query = query.Remove(query.Length - 5);
            }

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BusModel bus = new BusModel(row);
                BusResult.Add(bus);
            }

            return BusResult;
        }

        public void DeleteListEmployee(List<BusModel> Buses)
        {
            foreach (BusModel bus in Buses)
            {
                string query = "DELETE FROM BUS WHERE license_plate_no = '" + bus.LicensePlateNo + "'";

                DataProviderDAO.Instance.ExecuteQuery(query);
            }
        }

        public void AddListBus(BusModel bus)
        {
            string query = "INSERT INTO BUS VALUES('" + bus.LicensePlateNo + "','" + bus.TypeOfBus + "','" + bus.NumberOfSeats + "')";

            DataProviderDAO.Instance.ExecuteQuery(query);
        }

        public void EditBus(BusModel bus, string licensedPlateNo)
        {
            string query = "UPDATE BUS SET license_plate_no = '" + bus.LicensePlateNo + "', type_of_bus = '" + bus.TypeOfBus
                + "', number_of_seats = '" + bus.NumberOfSeats +  "' WHERE license_plate_no = '" + licensedPlateNo + "';";
            DataProviderDAO.Instance.ExecuteQuery(query);
        }
    }
}

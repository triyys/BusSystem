using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLibrary.Data_Transfer_Layer
{
    public class RouteModel
    {
        public RouteModel()
        {

        }

        public RouteModel(string routeId, int distance, string employeeId)
        {
            RouteId = routeId;
            Distance = distance;
            EmployeeId = employeeId;
        }

        public RouteModel(DataRow row)
        {
            RouteId = row["Route"].ToString();
            Distance = (int)row["Distance"];
            LastName = row["Ho"].ToString();
            FirstName = row["Ten"].ToString();
            Email = row["Email"].ToString();
            EmployeeId = row["EmployeeId"].ToString();
        }

        private string routeId;
        private int distance;
        private string lastName;
        private string firstName;
        private string email;
        private string employeeId;

        public string RouteId { get => routeId; set => routeId = value; }
        public int Distance { get => distance; set => distance = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Email { get => email; set => email = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
    }
}

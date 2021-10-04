using BusLibrary.Data_Transfer_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLibrary.Data_Access_Layer
{
    public class RouteDAO
    {
        private static RouteDAO instance;

        public static RouteDAO Instance
        {
            get { if (instance == null) instance = new RouteDAO(); return instance; }
            private set => instance = value;
        }

        private RouteDAO() { }

        public List<RouteModel> GetListAllRoute()
        {
            List<RouteModel> output = new List<RouteModel>();

            string query = "CALL bus_system.spRoute_GetAll();";

            DataTable table = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                RouteModel route = new RouteModel(row);

                output.Add(route);
            }

            return output;
        }

        /// <summary>
        /// Nhớ để cái nút ô text box cho chức năng search này mặc định là giá trị 0 giùm tui
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public List<RouteModel> FindRoutes(int distance = 0)
        {
            List<RouteModel> output = new List<RouteModel>();

            string query = $"CALL bus_system.spRoute_GetByDistance({ distance });";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                RouteModel route = new RouteModel(row);

                output.Add(route);
            }

            return output;
        }

        public void DeleteListRoute(List<RouteModel> routes)
        {
            string query = "";

            foreach (RouteModel route in routes)
            {
                query = $"DELETE FROM Route WHERE route_id = '{ route.RouteId }'";

                DataProviderDAO.Instance.ExecuteQuery(query);
            }
        }

        public void AddListRoute(RouteModel route)
        {
            string query = $"INSERT INTO Route (route_id, distance, operating_staff_id)" +
                $"value ('{ route.RouteId }', { route.Distance }, '{ route.EmployeeId }')";

            DataProviderDAO.Instance.ExecuteQuery(query);
        }

        public void EditRoute(RouteModel route, string routeId)
        {
            string query = $"CALL bus_system.spRoute_Update('{ routeId }', '{ route.RouteId }', { route.Distance }, '{ route.EmployeeId }');";

            DataProviderDAO.Instance.ExecuteQuery(query);
        }
    }
}

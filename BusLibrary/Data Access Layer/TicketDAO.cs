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
    public class TicketDAO
    {
        private static TicketDAO instance;

        public static TicketDAO Instance 
        {
            get { if (instance == null) instance = new TicketDAO(); return instance; }
            set => instance = value; 
        }

        private TicketDAO() { }

        public List<TicketModel> GetListAllTicket()
        {
            List<TicketModel> output = new List<TicketModel>();

            string query = "SELECT ticket_id, price, type_ticket, route_id, trip_no, payment_id FROM TICKET";

            DataTable table = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach(DataRow row in table.Rows)
            {
                TicketModel ticket = new TicketModel(row);

                output.Add(ticket);
            }

            return output;
        }

        public List<TicketModel> GetListAllTicketDESC()
        {
            List<TicketModel> output = new List<TicketModel>();

            string query = "SELECT ticket_id, price, type_ticket, route_id, trip_no, payment_id FROM ticket ORDER BY ticket_id DESC";

            DataTable table = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                TicketModel ticket = new TicketModel(row);

                output.Add(ticket);
            }

            return output;
        }


        public List<TicketModel> LookForTicket(string _ticketID,  string _type, int _price, string _routeID, int _tripNo, string _paymentID)
        {
            List<TicketModel> listTicket = new List<TicketModel>();
            string query = "SELECT ticket_id,  type_ticket, price, route_id, trip_no, payment_id FROM TICKET";
            bool head = true;
            DataTable data;

            if (!(_ticketID == null && _price == -1 && _type == null && _routeID == null && _tripNo == -1 && _paymentID == null))
            {
                query += " WHERE";
                if (_ticketID != null)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                        head = false;
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "ticket_id LIKE '%" + _ticketID +"%'";
                    query += additional_query;
                }

                if (_price != -1)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                        head = false;
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "price =" + _price.ToString();
                    query += additional_query;
                }

                if (_type != null)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                        head = false;
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "type_ticket = '" + _type + "'";
                    query += additional_query;
                }

                if (_routeID != null)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                        head = false;
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "route_id LIKE '%" + _routeID + "%'";
                    query += additional_query;
                }

                if (_tripNo != -1)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                        head = false;
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "trip_no = " + _tripNo.ToString();
                    query += additional_query;

                }

                if (_paymentID != null)
                {
                    string additional_query = " ";
                    if (head == true)
                    {
                    }
                    else
                    {
                        additional_query += "AND ";
                    }
                    additional_query += "payment_id LIKE '%" + _paymentID + "%'";
                    query += additional_query;
                }

                data = DataProviderDAO.Instance.ExecuteQuery(query);
            }
            else
            {

                data = DataProviderDAO.Instance.ExecuteQuery(query);
            }


            foreach (DataRow item in data.Rows)
            {
                TicketModel ticket = new TicketModel(item);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public void AddListTicket(TicketModel _ticket)
        {
            string query = "INSERT INTO TICKET VALUE('" + _ticket.TicketId + "','" + _ticket.Type + "'," + _ticket.Price.ToString() + ",'" + _ticket.PaymentId + "','" + _ticket.RouteId + "'," + _ticket.TripNo.ToString() + ")";
                
            //insert into ticket value('ZZZZZZZZZ', 'M', 100, 'ZZZZZZZZZZ', '01', 201);
            DataProviderDAO.Instance.ExecuteQuery(query);
        }

        public void DeleteListTicket(List<TicketModel> _listTicket)
        {
            foreach (TicketModel ticket in _listTicket)
            {
                string query = "DELETE FROM ticket WHERE ticket_id = '" + ticket.TicketId + "'";
                DataProviderDAO.Instance.ExecuteQuery(query);
            }
           
        }

        public void UpdateTicket(TicketModel _ticket, string __ticketID)
        {
            string query = "UPDATE ticket SET ticket_id = '" + _ticket.TicketId + "', type_ticket = '" + _ticket.Type + "', route_id = '" + _ticket.RouteId + "', payment_id = '" + _ticket.PaymentId + "', price = " + _ticket.Price.ToString() + ", trip_no = " + _ticket.TripNo.ToString() + " WHERE ticket_id = '" + __ticketID + "'";
            DataProviderDAO.Instance.ExecuteQuery(query);       
            
        }
    }
}

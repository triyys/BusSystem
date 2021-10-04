using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLibrary.Data_Transfer_Layer
{
    public class TicketModel
    {
        public TicketModel() { }

        public TicketModel(string ticketId, string type, int price, string routeId, int tripNo, string paymentId)
        {
            TicketId = ticketId;
            Type = type;
            Price = price;
            RouteId = routeId;
            TripNo = tripNo;
            PaymentId = paymentId;

        }

        public TicketModel(DataRow row)
        {
            TicketId = row["ticket_id"].ToString();
            Price = (int)row["price"];
            Type = row["type_ticket"].ToString();
            RouteId = row["route_id"].ToString();
            TripNo = (int)row["trip_no"];
            PaymentId = row["payment_id"].ToString();
        }

        private string ticketId;
        private string type;
        private int price;
        private string routeId;
        private int tripNo;
        private string paymentId;
        //private string cardId;// dành cho member và monthly, đối với non member thì dùng 1 mã "ZZZZZZZZZZ"

        public string Type { get => type; set => type = value; }
        public string RouteId { get => routeId; set => routeId = value; }
        public int TripNo { get => tripNo; set => tripNo = value; }
        public string TicketId { get => ticketId; set => ticketId = value; }
        public int Price { get => price; set => price = value; }
        public string PaymentId { get => paymentId; set => paymentId = value; }

    }
}
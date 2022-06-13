using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models
{
    public class RouteTicketModel
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public string TicketSurname { get; set; }
        public string TicketGender { get; set; }
        public string TicketMail { get; set; }
        public string TicketFromWhere { get; set; }
        public string TicketToWhere { get; set; }
        public string TicketDate { get; set; }
        public double TicketPrice { get; set; }
        public int TicketSeatNo { get; set; }
        public string RouteDate { get; set; }
        public double RouteClock { get; set; }
        public double RoutePrice { get; set; }
        public double RouteId { get; set; }
    }
}

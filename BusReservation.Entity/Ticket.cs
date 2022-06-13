using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required(ErrorMessage ="Lütfen İsminizi Giriniz.")]
        public string TicketName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisminiz Giriniz.")]
        public string TicketSurname { get; set; }
        public string TicketGender { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz.")]
        public string TicketMail { get; set; }
        public string TicketFromWhere { get; set; }
        public string TicketToWhere { get; set; }
        public string TicketDate { get; set; }
        public double TicketPrice { get; set; }
        public int TicketSeatNo { get; set; }
        public string TicketClock { get; set; }
        public string TicketPnrNo { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}

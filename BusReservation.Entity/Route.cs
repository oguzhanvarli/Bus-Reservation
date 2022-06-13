using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Entity
{
    public class Route
    {
        public int RouteId { get; set; }
        [Required(ErrorMessage ="Başlangıç Noktası Seçilmek Zorundadır")]
        public string RouteStart { get; set; }
        public string RouteFirstTransfer { get; set; }
        public string RouteSecondTransfer { get; set; }
        public string RouteThirdTransfer { get; set; }
        public string RouteFourthTransfer { get; set; }
        [Required(ErrorMessage = "Bitiş Noktası Seçilmek Zorundadır")]
        public string RouteFinish { get; set; }
        [Required(ErrorMessage = "Rota Tarihi Seçilmek Zorundadır")]
        public string RouteDate { get; set; }
        [Required(ErrorMessage = "Rota Saati Seçilmek Zorundadır")]
        public string RouteClock { get; set; }
        [Required(ErrorMessage = "Rota Fiyatı Seçilmek Zorundadır")]
        public double RoutePrice { get; set; }

        public List<City> City { get; set; }
    }
}

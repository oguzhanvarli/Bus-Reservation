using BusReservation.Data.Abstract;
using BusReservation.Entity;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Concrete.EfCore
{
    public class EfCoreRouteRepository : EfCoreGenericRepository<Route, BusResContext>, IRouteRepository
    {

        public List<Route> FindRoute(string cityStart, string cityLast, DateTime goingDate)
        {
            cityStart = cityStart.ToLower();
            cityLast = cityLast.ToLower();
            string goingDateFake = goingDate.ToString("yyyy-MM-dd");
 
            using (var context = new BusResContext())
            {
                
                var start = context.Routes.Where(i => i.RouteDate.Contains(goingDateFake) && (i.RouteStart.ToLower().Contains(cityStart) && 
                ((i.RouteFirstTransfer.ToLower().Contains(cityLast) ||
                i.RouteSecondTransfer.ToLower().Contains(cityLast) || i.RouteThirdTransfer.ToLower().Contains(cityLast) ||
                i.RouteFourthTransfer.ToLower().Contains(cityLast) || i.RouteFinish.ToLower().Contains(cityLast))) ||

                i.RouteFirstTransfer.ToLower().Contains(cityStart) && ((i.RouteSecondTransfer.ToLower().Contains(cityLast) ||
                i.RouteThirdTransfer.ToLower().Contains(cityLast) || i.RouteFourthTransfer.ToLower().Contains(cityLast) ||
                i.RouteFinish.ToLower().Contains(cityLast))) ||

                i.RouteSecondTransfer.ToLower().Contains(cityStart) && ((i.RouteThirdTransfer.ToLower().Contains(cityLast) ||
                i.RouteFourthTransfer.ToLower().Contains(cityLast) || i.RouteFinish.ToLower().Contains(cityLast))) ||

                i.RouteThirdTransfer.ToLower().Contains(cityStart) && ((i.RouteFourthTransfer.ToLower().Contains(cityLast) ||
                i.RouteFinish.ToLower().Contains(cityLast))) ||

                i.RouteFourthTransfer.ToLower().Contains(cityStart) && ((i.RouteFinish.ToLower().Contains(cityLast))))).ToList();

                return start;

                //if (start != null && finish != null && cityStart!=cityLast)
                //{
                    
                //    start.AddRange(finish);
                //    return start;
                //}
                //else
                //{
                //    return null;
                //}

               
                
            }
        }

        public Route FindRouteWithId(int id)
        {
            using (var context = new BusResContext())
            {
                var route = context.Routes.Find(id);
                return route;
            }
        }
        public int GetRouteFromRouteId(int id)
        {
            using (var context = new BusResContext())
            {
                int ticket = context.Routes.Where(i => i.RouteId == id).Select(i => i.RouteId).FirstOrDefault();
                return ticket;
            }
        }




        //public Route GetRouteWithCities()
        //{
        //    using (var context = new BusResContext())
        //    {
        //        return context.Routes.Include(i => i.City);
        //    }
        //}
    }
}

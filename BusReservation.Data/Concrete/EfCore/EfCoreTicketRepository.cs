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
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket, BusResContext>, ITicketRepository
    {
        public string GetDate(int id)
        {
            using (var context = new BusResContext())
            {
                var ticketDate = context.Routes.Where(i => i.RouteId == id).Select(i => i.RouteDate).FirstOrDefault();
                return ticketDate;
            }
        }

        public string GetHour(int id)
        {
            using(var context = new BusResContext())
            {
                var ticketHour = context.Routes.Where(i => i.RouteId == id).Select(i => i.RouteClock).FirstOrDefault();
                return ticketHour;
            }
        }

        public double GetPrice(int id)
        {
            using (var context = new BusResContext())
            {
                var ticketPrice = context.Routes.Where(i => i.RouteId == id).Select(i => i.RoutePrice).FirstOrDefault();
                return (double)ticketPrice;
            }
        }

        public Ticket GetSearchedTicket(string PnrNo, string Email)
        {
            Email = Email.ToLower();
            using (var context = new BusResContext())
            {
                var ticket = context
                    .Tickets
                    .Where(i => i.TicketPnrNo.Contains(PnrNo) && (i.TicketMail.ToLower().Contains(Email)))
                    .FirstOrDefault();
                return ticket;

            }
        }

        public List<Ticket> GetTicketsWithRoute(int id)
        {
            using (var context = new BusResContext())
            {
                return context.Tickets.Where(i => i.RouteId == id).ToList();
                //return context.Tickets.Where(i => i.RouteId == id).Include(i => i.Route).ToList();

            }
        }
        
    }
}

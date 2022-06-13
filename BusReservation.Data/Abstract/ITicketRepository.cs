using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Abstract
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        List<Ticket> GetTicketsWithRoute(int id);
        string GetDate(int id);
        double GetPrice(int id);
        string GetHour(int id);
        Ticket GetSearchedTicket(string PnrNo, string Email);


    }
}

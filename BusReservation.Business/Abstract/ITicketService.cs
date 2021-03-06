using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface ITicketService
    {
        Ticket GetById(int id);
        List<Ticket> GetAll();
        void Update(Ticket ticket);
        void Delete(Ticket ticket);
        void Create(Ticket ticket);
        public List<Ticket> GetTicketsWithRoute(int id);
        string GetDate(int id);
        double GetPrice(int id);
        string GetHour(int id);
        Ticket GetSearchedTicket(string PnrNo, string Email);
    }
}

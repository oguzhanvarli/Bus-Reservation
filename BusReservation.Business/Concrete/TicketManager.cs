using BusReservation.Business.Abstract;
using BusReservation.Data.Abstract;
using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public void Create(Ticket ticket)
        {
            _ticketRepository.Create(ticket);
        }

        public void Delete(Ticket ticket)
        {
            _ticketRepository.Delete(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public string GetDate(int id)
        {
            return _ticketRepository.GetDate(id);
        }

        public string GetHour(int id)
        {
            return _ticketRepository.GetHour(id);
        }

        public double GetPrice(int id)
        {
            return _ticketRepository.GetPrice(id);
        }

        public Ticket GetSearchedTicket(string PnrNo, string Email)
        {
            return _ticketRepository.GetSearchedTicket(PnrNo, Email);
        }

        public List<Ticket> GetTicketsWithRoute(int id)
        {
            return _ticketRepository.GetTicketsWithRoute(id);
        }

        public void Update(Ticket ticket)
        {
            _ticketRepository.Update(ticket);
        }
    }
}

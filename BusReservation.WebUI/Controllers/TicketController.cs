using BusReservation.Business.Abstract;
using BusReservation.Entity;
using BusReservation.WebUI.EmailServices;
using BusReservation.WebUI.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class TicketController : Controller
    {
        private ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Search(string PnrNo, string Email)
        {
            if (PnrNo == null || Email == null)
            {
                ShowMessage("Lütfen bilgilerin hepsini doldurun.", "danger");
                return RedirectToAction("Index", "Home");
            }
            var ticket = _ticketService.GetSearchedTicket(PnrNo, Email);
            if (ticket == null)
            {
                ShowMessage("Böyle bir bilet bulunmamaktadır.Lütfen bilgilerinizi kontrol ediniz.", "danger");
                return RedirectToAction("Index", "Home");
            }
            return View(ticket); 
        }
        public IActionResult TicketDelete(int ticketId)
{
            var entity = _ticketService.GetById(ticketId);
            _ticketService.Delete(entity);
            return RedirectToAction("Index", "Home");
        }
        private void ShowMessage(string message, string type)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                Type = type
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}

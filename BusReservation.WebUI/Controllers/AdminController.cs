using BusReservation.Business.Abstract;
using BusReservation.Entity;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IRouteService _routeService;
        private ICityService _cityService;
        private ITicketService _ticketService;
        public AdminController(IRouteService routeService, ICityService cityService, ITicketService ticketService)
        {
            _routeService = routeService;
            _cityService = cityService;
            _ticketService = ticketService;
        }
        public IActionResult ListRoutes()
        {
            var routes = _routeService.GetAll();
            return View(routes);
        }
        public IActionResult CreateRoute()
        {
            ViewBag.Cities = _cityService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult CreateRoute(Route route)
        {
            //route.RouteDate = route.RouteDate.ToString("dd.MM.yyyy");
            _routeService.Create(route);
            return RedirectToAction("ListRoutes");
        }
        public IActionResult DeleteRoute(int routeId)
        {
            var entity = _routeService.GetById(routeId);
            _routeService.Delete(entity);
            return RedirectToAction("ListRoutes");
        }
        public IActionResult TicketList() 
        {
            return View(_ticketService.GetAll());
        }
        public IActionResult DeleteTicket(int ticketId)
        {
            var entity = _ticketService.GetById(ticketId);
            _ticketService.Delete(entity);
            return RedirectToAction("TicketList");
        }
    }
}

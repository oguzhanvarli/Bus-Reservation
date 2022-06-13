using BusReservation.Business.Abstract;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.ViewComponents
{
    public class SelectSeat : ViewComponent
    {
        private IRouteService _routeService;
        public SelectSeat(IRouteService routeService)
        {
            _routeService = routeService;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View(_routeService.FindRouteWithId(id));
        }
    }
}

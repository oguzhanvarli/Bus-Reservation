using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Business.Abstract
{
    public interface IRouteService
    {
        Route GetById(int id);
        List<Route> GetAll();
        void Update(Route route);
        void Create(Route route);
        void Delete(Route route);
        public List<Route> FindRoute(string cityStart, string cityLast, DateTime goingDate);
        public Route FindRouteWithId(int id);
        public int GetRouteFromRouteId(int id);


    }
}

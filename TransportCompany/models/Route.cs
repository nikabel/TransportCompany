using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Route
    {
        private string _routeId;
        private string _driverName;
        private string _ApplicationNum;
        private int _totalDistance;
        private DateTime _departureDate;
        private DateTime _arrivalDate;

        public Route(string routeId, string driverName, string applicationNum, int totalDistance, DateTime departureDate, DateTime arrivalDate)
        {
            RouteId = routeId;
            DriverName = driverName;
            ApplicationNum = applicationNum;
            TotalDistance = totalDistance;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
        }

        public string RouteId { get => _routeId; set => _routeId = value; }
        public string DriverName { get => _driverName; set => _driverName = value; }
        public string ApplicationNum { get => _ApplicationNum; set => _ApplicationNum = value; }
        public int TotalDistance { get => _totalDistance; set => _totalDistance = value; }
        public DateTime DepartureDate { get => _departureDate; set => _departureDate = value; }
        public DateTime ArrivalDate { get => _arrivalDate; set => _arrivalDate = value; }
    }
}

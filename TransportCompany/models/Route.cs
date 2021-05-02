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
        private string _employeeName;
        private string _ApplicationNum;
        private int _totalDistance;
        private DateTime _planDepartureDate;
        private DateTime _planArrivalDate;
        private DateTime _factDepartureDate;
        private DateTime _factArrivalDate;

        public Route(string routeId, string employeeName, string applicationNum, int totalDistance, DateTime planDepartureDate, DateTime planArrivalDate, DateTime factDepartureDate, DateTime factArrivalDate)
        {
            RouteId = routeId;
            EmployeeName = employeeName;
            ApplicationNum = applicationNum;
            TotalDistance = totalDistance;
            PlanDepartureDate = planDepartureDate;
            PlanArrivalDate = planArrivalDate;
            FactDepartureDate = factDepartureDate;
            FactArrivalDate = factArrivalDate;
        }

        public string RouteId { get => _routeId; set => _routeId = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public string ApplicationNum { get => _ApplicationNum; set => _ApplicationNum = value; }
        public int TotalDistance { get => _totalDistance; set => _totalDistance = value; }
        public DateTime PlanDepartureDate { get => _planDepartureDate; set => _planDepartureDate = value; }
        public DateTime PlanArrivalDate { get => _planArrivalDate; set => _planArrivalDate = value; }
        public DateTime FactDepartureDate { get => _factDepartureDate; set => _factDepartureDate = value; }
        public DateTime FactArrivalDate { get => _factArrivalDate; set => _factArrivalDate = value; }
    }
}

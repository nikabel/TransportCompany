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

        public Route(string routeId, string employeeName, string applicationNum, int totalDistance)
        {
            RouteId = routeId;
            EmployeeName = employeeName;
            ApplicationNum = applicationNum;
            TotalDistance = totalDistance;
        }

        public string RouteId { get => _routeId; set => _routeId = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public string ApplicationNum { get => _ApplicationNum; set => _ApplicationNum = value; }
        public int TotalDistance { get => _totalDistance; set => _totalDistance = value; }
    }
}

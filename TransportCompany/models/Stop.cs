using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Stop
    {
        private string _stopId;
        private string _stopAddress;
        private string _routeId;
        private string _operationName;
        private DateTime _planStopDate;
        private DateTime _factStopDate;

        public Stop(string stopId, string stopAddress, string routeId, string operationName, DateTime planStopDate, DateTime factStopDate)
        {
            StopId = stopId;
            StopAddress = stopAddress;
            RouteId = routeId;
            OperationName = operationName;
            PlanStopDate = planStopDate;
            FactStopDate = factStopDate;
        }

        public string StopId { get => _stopId; set => _stopId = value; }
        public string StopAddress { get => _stopAddress; set => _stopAddress = value; }
        public string RouteId { get => _routeId; set => _routeId = value; }
        public string OperationName { get => _operationName; set => _operationName = value; }
        public DateTime PlanStopDate { get => _planStopDate; set => _planStopDate = value; }
        public DateTime FactStopDate { get => _factStopDate; set => _factStopDate = value; }
    }
}

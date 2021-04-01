using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class StopRoute
    {
        private string _stopAddress;
        private string _routeId;
        private int _stopCount;

        public StopRoute(string stopAddress, string routeId, int stopCount)
        {
            StopAddress = stopAddress;
            RouteId = routeId;
            StopCount = stopCount;
        }

        public string StopAddress { get => _stopAddress; set => _stopAddress = value; }
        public string RouteId { get => _routeId; set => _routeId = value; }
        public int StopCount { get => _stopCount; set => _stopCount = value; }
    }
}

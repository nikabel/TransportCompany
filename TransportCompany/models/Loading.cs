using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Loading
    {
        private string _routeId;
        private string _loadingAddress;
        private DateTime _loadingDate;

        public Loading(string routeId, string loadingAddress, DateTime loadingDate)
        {
            RouteId = routeId;
            LoadingAddress = loadingAddress;
            LoadingDate = loadingDate;
        }

        public string RouteId { get => _routeId; set => _routeId = value; }
        public string LoadingAddress { get => _loadingAddress; set => _loadingAddress = value; }
        public DateTime LoadingDate { get => _loadingDate; set => _loadingDate = value; }
    }
}

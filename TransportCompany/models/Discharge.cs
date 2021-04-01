using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Discharge
    {
        private string _routeId;
        private string _dischargeAddress;
        private DateTime _dischargeDate;

        public Discharge(string routeId, string dischargeAddress, DateTime dischargeDate)
        {
            RouteId = routeId;
            DischargeAddress = dischargeAddress;
            DischargeDate = dischargeDate;
        }

        public string RouteId { get => _routeId; set => _routeId = value; }
        public string DischargeAddress { get => _dischargeAddress; set => _dischargeAddress = value; }
        public DateTime DischargeDate { get => _dischargeDate; set => _dischargeDate = value; }
    }
}

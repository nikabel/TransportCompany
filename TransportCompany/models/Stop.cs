using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Stop
    {
        private string _stopAddress;
        private DateTime _stopDate;
        private string _stopTypeName;

        public Stop(string stopAddress, DateTime stopDate, string stopTypeName)
        {
            StopAddress = stopAddress;
            StopDate = stopDate;
            StopTypeName = stopTypeName;
        }

        public string StopAddress { get => _stopAddress; set => _stopAddress = value; }
        public DateTime StopDate { get => _stopDate; set => _stopDate = value; }
        public string StopTypeName { get => _stopTypeName; set => _stopTypeName = value; }
    }
}

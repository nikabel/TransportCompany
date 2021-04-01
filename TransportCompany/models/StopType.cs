using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class StopType
    {
        private string _stopTypeName;
        private string _stopTypeDesc;

        public StopType(string stopTypeName, string stopTypeDesc)
        {
            StopTypeName = stopTypeName;
            StopTypeDesc = stopTypeDesc;
        }

        public string StopTypeName { get => _stopTypeName; set => _stopTypeName = value; }
        public string StopTypeDesc { get => _stopTypeDesc; set => _stopTypeDesc = value; }
    }
}

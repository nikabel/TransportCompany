using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Specialization
    {
        private string _specName;
        private string _specDesc;

        public Specialization(string specName, string specDesc)
        {
            SpecName = specName;
            SpecDesc = specDesc;
        }

        public string SpecName { get => _specName; set => _specName = value; }
        public string SpecDesc { get => _specDesc; set => _specDesc = value; }
    }
}

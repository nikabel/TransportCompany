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

        public Specialization(string specName)
        {
            SpecName = specName;
        }

        public string SpecName { get => _specName; set => _specName = value; }
    }
}

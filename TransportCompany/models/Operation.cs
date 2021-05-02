using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Operation
    {
        private string _operationName;

        public Operation(string operationName)
        {
            OperationName = operationName;
        }

        public string OperationName { get => _operationName; set => _operationName = value; }
    }
}

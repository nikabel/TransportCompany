using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string customerName, string customerEmail, string customerTel, string customerAddress) 
            : base(customerName, customerEmail, customerTel, customerAddress)
        {
        }
    }
}

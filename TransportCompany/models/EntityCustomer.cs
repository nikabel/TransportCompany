using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class EntityCustomer : Customer
    {
        private string _orgName;
        private string _customerBussinessAddress;
        public EntityCustomer(string customerName, string customerEmail, string customerTel, string customerAddress, string customerBussinessAddress, string orgName) 
            : base(customerName, customerEmail, customerTel, customerAddress)
        { 
            OrgName = orgName;
            CustomerBussinessAddress = customerBussinessAddress;
        }

        public string OrgName { get => _orgName; set => _orgName = value; }
        public string CustomerBussinessAddress { get => _customerBussinessAddress; set => _customerBussinessAddress = value; }
    }
}

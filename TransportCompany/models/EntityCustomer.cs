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
        public EntityCustomer(string customerName, string customerEmail, string customerTel, string customerAddress, string customerBussinessAddress, string orgName) 
            : base(customerName, customerEmail, customerTel, customerAddress, customerBussinessAddress)
        { OrgName = orgName; }

        public string OrgName { get => _orgName; set => _orgName = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class Customer
    {
        private string _customerName;
        private string _customerEmail;
        private string _customerTel;
        private string _customerAddress;
        private string _customerBussinessAddress;

        public Customer(string customerName, string customerEmail, string customerTel, string customerAddress)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerTel = customerTel;
            CustomerAddress = customerAddress;
        }

        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string CustomerEmail { get => _customerEmail; set => _customerEmail = value; }
        public string CustomerTel { get => _customerTel; set => _customerTel = value; }
        public string CustomerAddress { get => _customerAddress; set => _customerAddress = value; }
    }
}

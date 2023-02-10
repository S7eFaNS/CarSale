using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Model
{
    public class Customer
    {
        private string name;
        private string phone;
        private string address;
        private string zip_city;

        public Customer(string name, string phone, string address, string zip_city)
        {
            GetName = name;
            GetPhone = phone;
            GetAddress = address;
            GetZip_City = zip_city;
        }

        public string GetName
        {
            get { return name; }
            set { name = value; }
        }

        public string GetPhone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string GetAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string GetZip_City
        {
            get { return zip_city; }
            set { zip_city = value; }
        }
    }
}

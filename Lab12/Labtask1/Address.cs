using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementApp
{
    public class Address
    {
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{AddressLine}, {City}, {PostalCode}";
        }
    }
}


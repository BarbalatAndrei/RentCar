using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Customers
{
    public class CustomerList
    {
        public List<Customer> customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            customers.Add(new Customer().inserCustomer(1, "Victor", "Boghean", "012345678", "mun. Chisinau"));
            customers.Add(new Customer().inserCustomer(2, "Ion", "Dermengi", "987456123", "mun. Chisinau"));
            customers.Add(new Customer().inserCustomer(3, "Liova", "Puscasu", "456987121", "mun. Chisinau"));
            customers.Add(new Customer().inserCustomer(4, "Mihai", "Ciubotaru", "456987124", "mun. Chisinau"));

            return customers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoReapir.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {
            Customer customer;

            customer = new Customer();
            customer.FirstName = "Ben";
            customer.LastName = "Mentink";
            customer.PhoneNumber= "1234567890";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "John";
            customer.LastName = "Doe";
            customer.PhoneNumber = "1234567890";
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Jim";
            customer.LastName = "Ronalds";
            customer.PhoneNumber = "1234567890";
            Add(customer);
        }
    }
}

using BJM.AutoRepair.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BJM.AutoRepair.BL.Vehicle;

namespace BJM.AutoReapir.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {
            Customer customer;
            Vehicle car;

            customer = new Customer();
            customer.FirstName = "Ben";
            customer.LastName = "Mentink";
            customer.PhoneNumber= "1234567890";
            customer.Vehicles.Add(new Vehicle("Maserati", "MC20", 2022));
            customer.Vehicles.Add(new Vehicle("Chevy", "Camaro", 2022));
            Add(customer);

            customer = new Customer();
            customer.FirstName = "John";
            customer.LastName = "Doe";
            customer.PhoneNumber = "1234567890";
            customer.Vehicles.Add(new Vehicle("BMW", "X5", 2000));
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Jim";
            customer.LastName = "Ronalds";
            customer.PhoneNumber = "1234567890";
            customer.Vehicles.Add(new Vehicle("Mini", "Cooper", 2005));
            Add(customer);
        }
    }
}

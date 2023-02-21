﻿using BJM.AutoRepair.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoReapir.BL
{
    public class Customer : Person
    {
        public string PhoneNumber { get; set; } = string.Empty;

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public Customer() 
        {
            FirstName = "Ben";
            DOB = new DateTime(1983, 6 ,17);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoReapir.UI
{
    public class Customer
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string FullName 
        { 
            get { return FirstName + " " + LastName; } 
        }
        // methods 
        public override string ToString()
        {
            return FullName;
        }
    }
}

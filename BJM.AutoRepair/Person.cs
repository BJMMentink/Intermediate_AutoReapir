using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoReapir.BL
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        protected DateTime DOB { get; set; }
        // methods
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public override string ToString()
        {
            return FullName;
        }

    }
}

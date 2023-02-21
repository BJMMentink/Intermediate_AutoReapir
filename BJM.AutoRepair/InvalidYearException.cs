using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        //properties
        public int InvalidYear { get; set; }
        // constructor
        public InvalidYearException(int invalidYear) 
            : base(invalidYear + "is not a valid year")
        {
            InvalidYear = invalidYear;
            
        }
    }
}

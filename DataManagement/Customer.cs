using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        // returns the entire name in a string, can also do other things like calculations or expressions before returning
        // the property
        public string FullName 
        { 
            get 
            { 
                return $"{FirstName}, {LastName}"; 
            } 
        }
    }
}

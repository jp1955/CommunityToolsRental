using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    // use this class to represent data in a way human can understand instead of just numbers
    // show tool name and customer name instead of IDs
    public class LoanView
    {
        public int LoanID { get; set; }

        // swap out customerID for lastName and firstName
        public string LastName { get; set; }
        public string FirstName { get; set; }

        // replace toolID with tooltype and toolmake
        public string ToolType { get; set; }
        public string ToolMake { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; } // if date rented is not nullable it adds a default date behind the scene
        public string ToolCondition { get; set; }
        public string Notes { get; set; }
    }
}

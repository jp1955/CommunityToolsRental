using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int CustomerID { get; set; }
        public int ToolID { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; } // ? allows it to be null
        public string Condition { get; set; }
        public string Notes { get; set; }

        public Loan() { }

        public Loan(int cust, int tool, DateTime rented, string condition, string notes)
        {
            CustomerID = cust;
            ToolID = tool;
            DateRented = rented;
            Condition = condition;
            Notes = notes;
        }


        public Loan(int cust, int tool, DateTime rented, DateTime returned, string condition, string notes)
        {
            CustomerID = cust;
            ToolID = tool;
            DateRented = rented;
            DateReturned = returned;
            Condition = condition;
            Notes = notes;
        }
    }
}

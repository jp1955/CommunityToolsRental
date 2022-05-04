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

        public Loan() { }

        public Loan(int cust, int tool, DateTime rented)
        {
            CustomerID = cust;
            ToolID = tool;
            DateRented = rented;
        }


        public Loan(int cust, int tool, DateTime rented, DateTime returned)
        {
            CustomerID = cust;
            ToolID = tool;
            DateRented = rented;
            DateReturned = returned;
        }
    }
}

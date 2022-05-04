using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class Tool
    {
        public int ToolID { get; set; }

        // irrelevant field
        public string displayToolStatus
        {
            get
            {
                if (ToolCondition.Equals("Retired"))
                {
                    return "Retired";
                }

                else
                {
                    return "Active";
                }
            }
        }
        public bool Rented { get; set; }
        public bool Active { get; set; } // used to get a value for a Status column in Tool List
        public string ToolType { get; set; }
        public string ToolMake { get; set; }
        public string ToolCondition { get; set; }
        public string Notes { get; set; }

        // return full tool details for combo box of newLoan form
        public string FullToolDetails { get { return $"{ToolType}, {ToolMake}"; } }
        public Tool() { }

        public Tool(bool status, string type, string make, string condition, string description)
        {
            Active = status;
            ToolType = type;
            ToolMake = make;
            ToolCondition = condition;
            Notes = description;
        }

    }
}

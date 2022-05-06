using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// handles requests with dapper from Server Management to Visual Studio
// every table should have a GetAll, GetSingle, GetbyID, AddNew, Save, Delete
namespace DataManagement
{
    public class Adapter
    {
        /// <summary>
        /// Get all customers from selected table
        /// </summary>
        /// <returns></returns>
        #region Customers
        public List<Customer> GetAllCustomers()
        {
            string sql = "SELECT * FROM Customers"; // store the SQL command in a string to pass it easily
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Customer>(sql).ToList();
            }
        }

        /// <summary>
        /// Get a single customer details by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Details of a single customer</returns>
        public Customer GetSingleCustomerDetails(int id)
        {
            string sql = $"SELECT * FROM Customers WHERE CustomerID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Customer>(sql);
            }
        }

        // need a query to insert a new entry into the database
        /// <summary>
        /// Add one new customer into the database
        /// </summary>
        /// <param name="newCustomer"></param>
        public void AddNewCustomer(Customer newCustomer)
        {
            string sql = "INSERT INTO Customers " + "(LastName,FirstName,Phone) " +
                "VALUES (@LastName,@FirstName,@Phone)";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newCustomer);
            }
        }

        /// <summary>
        /// Save the customer details in an edit
        /// </summary>
        /// <param name="updatedCustomer"></param>
        public void SaveExistingCustomer(Customer updatedCustomer)
        {
            string sql = "UPDATE Customers SET " +
                "LastName = @LastName, FirstName = @FirstName, " +
                "Phone = @Phone " +
                $"WHERE CustomerID = {updatedCustomer.CustomerID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, updatedCustomer);
            }
        }

        /// <summary>
        /// Delete a single customer details by ID
        /// </summary>
        /// <param name="id"></param>
        public void DeleteSingleCustomer(int id) // primary key of the person we want to delete
        {
            try
            {
                string sql = $"DELETE FROM Customers WHERE CustomerID = {id}";
                using (var connection = Helper.CreateDatabaseConnection())
                {
                    connection.Execute(sql); // runs the query 
                }
            }
            catch (Exception)
            {
                // can't use messagebox.show outside windows form
                // MessageBox.Show("Error, could not delete properly", e);

            }
        }

        #endregion

        #region Tools

        /// <summary>
        /// Get all the tools in the database
        /// </summary>
        /// <returns></returns>
        // this method for setting up the tool table
        public List<Tool> GetAllTools()
        { 
            string sql = "SELECT * FROM Tools"; // store the SQL command in a string to pass it easily
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Tool>(sql).ToList();
            }
        }
        
        /// <summary>
        /// Get a single tool details by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tool GetSingleToolDetails(int id)
        {
            string sql = $"SELECT * FROM Tools WHERE ToolID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Tool>(sql);
            }
        }

        /// <summary>
        /// Get the tool status, passing two ints for availability and active
        /// </summary>
        /// <param name="availability"></param>
        /// <param name="rented"></param>
        /// <returns></returns>
         // this method is used for the cboToolStatus in the new loan frm to only show available tools
        public List<Tool> GetToolStatus(int availability, int rented) // pass a status either 0 or 1 for active or not, 0 = available
        {

            string sql = $"SELECT * FROM Tools WHERE Active = {availability} AND Rented = {rented}"; // store the SQL command in a string to pass it easily
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Tool>(sql).ToList();
            }
        }

        /// <summary>
        /// Update the active status, used to retire a tool or not
        /// </summary>
        /// <param name="active"></param>
        /// <param name="tool"></param>
        public void UpdateToolActiveStatus(int active, Tool tool)
        {
            string sql = "UPDATE Tools SET " +
                         $"Active = {active} " +
                         $"WHERE ToolID = {tool.ToolID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, tool);
            }
        }

        /// <summary>
        /// Update the loan status of a tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rented"></param>
        public void UpdateToolLoanStatus(int id, int rented)
        {
            string sql = "UPDATE Tools SET " +
                         "ToolCondition = @ToolCondition " +
                         $"Rented = {rented} " +
                         $"WHERE ToolID = {id}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, id);
            }
        }
        // select distinct will not pick any repeated entries
        public List<Tool> GetToolStatus()
        {
            string sql = "SELECT DISTINCT Active FROM Tools";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Tool>(sql).ToList();
            }
        }

        /// <summary>
        /// Add a new tool to the database with all the columns such as Rented, Active, Tooltype, etc
        /// </summary>
        /// <param name="tool"></param>
        public void AddNewTool(Tool tool)
        {
           
            string sql = "INSERT INTO Tools " + "(Rented,Active,ToolType,ToolMake,ToolCondition,Notes) " +
                           "VALUES (@Rented,@Active,@ToolType,@ToolMake,@ToolCondition,@Notes)";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, tool);
            }
        }

        /// <summary>
        /// Save an existing tool details using the UPDATE Tools SET SQL command
        /// </summary>
        /// <param name="updatedTool"></param>
        public void SaveExistingTool(Tool updatedTool)
        {
            string sql = "UPDATE Tools SET " +
                "ToolType = @ToolType, ToolMake = @ToolMake, " +
                "ToolCondition = @ToolCondition, Notes = @Notes " +
                $"WHERE ToolID = {updatedTool.ToolID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, updatedTool);
            }
        }

        /// <summary>
        /// Delete a single tool by ID
        /// </summary>
        /// <param name="id"></param>
        public void DeleteSingleTool(int id) // primary key of the tool we want to delete
        {
            try
            {
                string sql = $"DELETE FROM Tools WHERE ToolID = {id}";
                using (var connection = Helper.CreateDatabaseConnection())
                {
                    connection.Execute(sql); // runs the query 
                }
            }
            catch (Exception)
            {
                // can't use messagebox.show outside windows form
                // MessageBox.Show("Error, could not delete properly", e);

            }
        }
        #endregion

        #region Loans
        /// <summary>
        /// Add a new loan
        /// </summary>
        /// <param name="loan"></param>
        public void AddNewLoan(Loan loan)
        {
            string sql = "INSERT INTO ToolLoans " + "(CustomerID,ToolID,DateRented,ToolCondition,Notes) " +
                           "VALUES (@CustomerID,@ToolID,@DateRented,@ToolCondition,@Notes)";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, loan);
            }
        }

        /// <summary>
        /// Get a single loan by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Loan GetLoanByID(int id)
        {
            string sql = $"SELECT * FROM ToolLoans WHERE LoanID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Loan>(sql);
            }
        }
        
        /// <summary>
        /// Get all loans, to show in a grid view or else
        /// </summary>
        /// <returns></returns>
        public List<LoanView> GetAllLoans()
        {
            string sql = "SELECT ToolLoans.LoanID, Customers.LastName, Customers.FirstName, Tools.ToolType, Tools.ToolMake, " + 
                          "ToolLoans.DateRented, ToolLoans.DateReturned, Tools.ToolCondition, Tools.Notes " +
                          "FROM Customers " +
                          "INNER JOIN " +
                          "ToolLoans ON Customers.CustomerID = ToolLoans.CustomerID " +
                          "INNER JOIN " +
                          "Tools ON ToolLoans.ToolID = Tools.ToolID ";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<LoanView>(sql).ToList(); // pass the sql through to Visual Studio
            }
        }

        /// <summary>
        /// Get all loans by ID with a LoanView object that's easier to read than a Loan object
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<LoanView> GetAllLoans(int id)
        {
            string sql = "SELECT ToolLoans.LoanID, Customers.LastName, Customers.FirstName, Tools.ToolType, Tools.ToolMake, " +
                          "ToolLoans.DateRented, ToolLoans.DateReturned, Tools.ToolCondition, Tools.Notes " +
                          "FROM Customers " +
                          "INNER JOIN " +
                          "ToolLoans ON Customers.CustomerID = ToolLoans.CustomerID " +
                          "INNER JOIN " +
                          "Tools ON ToolLoans.ToolID = Tools.ToolID " +
                          "WHERE (ToolLoans.DateReturned IS NULL AND " +
                          $"ToolLoans.CustomerID = {id})";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<LoanView>(sql).ToList(); // pass the sql through to Visual Studio
            }
        }

        /// <summary>
        /// Save existing loan, used to update a loan
        /// </summary>
        /// <param name="updatedLoan"></param>
        public void SaveExistingLoan(Loan updatedLoan)
        {
            
            string sql = "UPDATE ToolLoans SET " +
                "DateReturned = @DateReturned, ToolCondition = @ToolCondition, " +
                "Notes = @Notes " +
                $"WHERE LoanID = {updatedLoan.LoanID}";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, updatedLoan);
            }

        }
        #endregion
    }
}

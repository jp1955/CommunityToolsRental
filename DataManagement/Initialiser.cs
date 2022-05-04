using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    // extends Adapter(class) and implements IDataIntialiser (interface)
    public class Initialiser : Adapter, IDataInitialiser
    {
        public void BuildDataBase()
        {
            CreateDatabase();
            if (DoTableExists() == false)
            {
                CreateTables();
                SeedDataBase();
            }
        }

        #region Creating Tables
        private void CreateTables()
        {
            CreateCustomerTable();
            CreateToolsTable();
            CreateLoansTable();
        }

        // create indivdual tables
        // Need one of these for every table you want to create
        private void CreateCustomerTable()
        {
            string tableName = "Customers";
            string structure = "CustomerID int IDENTITY (1,1) PRIMARY KEY, " +
                               "LastName VARCHAR(50) NOT NULL, " + 
                               "FirstName VARCHAR(50) NOT NULL, " +
                               "Phone VARCHAR(20) NOT NULL";
            CreateNewTable(tableName, structure);

        }

        // Example by Troy, change to suit tools
        private void CreateToolsTable()
        {
            string tableName = "Tools";
            string structure = "ToolID int IDENTITY (1,1) PRIMARY KEY, " + 
                               "Active bit NOT NULL, " +
                               "Rented bit NOT NULL, " +
                               "ToolType VARCHAR(50) NOT NULL, " +
                               "ToolMake VARCHAR(50) NOT NULL, " +
                               "ToolCondition VARCHAR(50) NOT NULL, " +
                               "Notes VARCHAR(100) NOT NULL ";

            CreateNewTable(tableName, structure);
        }

        private void CreateLoansTable()
        {
            string tableName = "ToolLoans";
            string structure = "LoanID int IDENTITY (1,1) PRIMARY KEY, " +
                               "CustomerID int NOT NULL, " +
                               "ToolID int NOT NULL, " +
                               "DateRented DATETIME NOT NULL, " + 
                               "DateReturned DATETIME NULL, " +
                               // no commas between separate sections
                               "FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID), " + 
                               "FOREIGN KEY(ToolID) REFERENCES Tools(ToolID) " ;

            CreateNewTable(tableName, structure);
        }

        #endregion

        #region Seeding Tables
        public void SeedDataBase()
        {
            // Creating tables in order is important because they are data dependent
            SeedCustomerTable();
            SeedToolsTable();
            SeedLoansTable();
        }

        // also need new seed method for every table
        private void SeedCustomerTable()
        {
            // Don't need to add customer ID they are auto generated
            List<Customer> newCustomers = new List<Customer>();
            newCustomers.Add(new Customer{ LastName = "Lin", FirstName = "Jeremy", Phone = "0451 111 232"});
            newCustomers.Add(new Customer{ LastName = "Bryant", FirstName = "Kobe", Phone = "0451 442 838"});
            newCustomers.Add(new Customer{ LastName = "James", FirstName = "Lebron", Phone = "0451 211 232"});
            newCustomers.Add(new Customer{ LastName = "Young", FirstName = "Trae", Phone = "0451 988 112"});
            newCustomers.Add(new Customer{ LastName = "Richard", FirstName = "Feynman", Phone = "0451 829 112"});
            newCustomers.Add(new Customer{ LastName = "Einstein", FirstName = "Albert", Phone = "0412 144 232"});
            newCustomers.Add(new Customer{ LastName = "Edison", FirstName = "Thomas", Phone = "0499 144 898"});

            // using a constructor
            // newCustomers.Add(new Customer("jordan", "michael", "0441 599 232"));

            foreach( var customer in newCustomers)
            {
                AddNewCustomer(customer);
            }
        }

        private void SeedToolsTable()
        {

            // create the tool list
            List<Tool> newTools = new List<Tool>();
            newTools.Add(new Tool { Rented = true, Active = true, ToolType = "Grinder", ToolMake = "Makita", ToolCondition = "New", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = false, Active = true, ToolType = "Drill", ToolMake = "Makita", ToolCondition = "New", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = true, Active = true, ToolType = "Hammer", ToolMake = "Makita", ToolCondition = "New", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = true, Active = true, ToolType = "Hacksaw", ToolMake = "Stanley", ToolCondition = "New", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = true, Active = true, ToolType = "Knife", ToolMake = "Stanley", ToolCondition = "Worn out", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = false, Active = true, ToolType = "Hammer", ToolMake = "Stanley", ToolCondition = "New", Notes = "Good condition" });
            newTools.Add(new Tool { Rented = false, Active = false, ToolType = "Mower", ToolMake = "Ryobi", ToolCondition = "Retired", Notes = "Damaged" });
            newTools.Add(new Tool { Rented = false, Active = false, ToolType = "Snipper", ToolMake = "Ryobi", ToolCondition = "Retired", Notes = "Damaged" });
            newTools.Add(new Tool { Rented = false, Active = false, ToolType = "Sledgehammer", ToolMake = "Milwaukee", ToolCondition = "Retired", Notes = "Damaged" });


            // need this foreach loop to add the tools to the table
            foreach (var tool in newTools)
            {
                AddNewTool(tool);
            }

        }

        private void SeedLoansTable()
        {
            List<Loan> newLoans = new List<Loan>();
            
            // system.datetime.now gets the current time
            // can only seed primary keys and foreign keys that already exist, and index starts from 1 not 0
            newLoans.Add(new Loan(1, 1, System.DateTime.Now.AddDays(-2).AddHours(3)));
            newLoans.Add(new Loan(2, 3, System.DateTime.Now.AddDays(-1).AddHours(5)));
            newLoans.Add(new Loan(3, 5, System.DateTime.Now.AddDays(-5).AddHours(2)));
            newLoans.Add(new Loan(4, 4, System.DateTime.Now.AddDays(-11).AddHours(9)));

            foreach (var loan in newLoans)
            {
                AddNewLoan(loan);
            }

        }

        #endregion

        #region Database Building

        // To build the database programmatically
        // This code never change, only the connection variables changes
        public void CreateDatabase()
        {
            SqlConnection connection = Helper.CreateDatabaseConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                string connectionString = $"Data Source = {connection.DataSource}; " +
                                          $"Integrated Security = True";

                // query to build data base if it does not already exist
                string sql = $"IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE " +
                             $"name = '{connection.Database}' ) " +
                             $"CREATE DATABASE {connection.Database}";
                using (SqlConnection connServer = new SqlConnection(connectionString))
                {
                    using (command = new SqlCommand(sql, connServer))
                    {
                        if (connServer.State == System.Data.ConnectionState.Closed)
                        {
                            connServer.Open();
                        }
                        command.ExecuteNonQuery();
                        connServer.Close();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool DoTableExists()
        {
            var connection = Helper.CreateDatabaseConnection();
            
            // look for tables that exist, returns 0 if none, postive number if there are
            string sql = $"SELECT COUNT(*) FROM " + 
                         $"{connection.Database}.INFORMATION_SCHEMA.TABLES " + 
                         $"WHERE TABLE_TYPE = 'BASE TABLE'";

            using (connection)
            {
                int num = connection.QuerySingle<int>(sql);
                if (num > 0)
                {
                    return true;
                }

                return false;
            }
        }

        // structure is part of a query
        private void CreateNewTable(string tableName, string structure)
        {
            // structure tells the primary key, foreign keys, etc... (built separately)
            string sql = $"CREATE TABLE {tableName} ({structure})";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                try
                {
                    connection.Execute(sql);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

        }
        #endregion
    }
}

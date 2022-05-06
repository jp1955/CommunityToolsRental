using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// hold data models, DAPPER
namespace DataManagement
{
    public static class Helper
    {
        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static SqlConnection CreateDatabaseConnection()
        {
            return new SqlConnection(GetConnectionString("Library"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Windows95.Models
{
    public static class SqlDatabaseConnection
    {
        public static string GetConnectionString(string connectionString = "windows95")
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        }
    }
}
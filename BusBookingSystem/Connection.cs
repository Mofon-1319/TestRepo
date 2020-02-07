using System.Configuration;
using System.Data.SqlClient;
using System;

namespace BusApp
{
    class Connection
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = @"Data Source=DESKTOP-RLL3JF9\SQLEXPRESS;Initial Catalog=BusBookingSystem;Integrated Security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}

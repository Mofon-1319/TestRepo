using System.Configuration;
using System.Data.SqlClient;

namespace BusBookingSystem.DAL
{
    class Connection
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}

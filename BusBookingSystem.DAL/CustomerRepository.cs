using BusBookingSystem.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusBookingSystem.DAL
{
    interface iCustomerRepository
    {
        int LogIn(Customer customer);
        int SignUp(Customer customer);
    }
    public class CustomerRepository : iCustomerRepository
    {
        public int SignUp(Customer customer)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string idQuery = "SP_SignUp";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter();
                para.ParameterName = "@UserId";
                para.Value = customer.userId;
                para.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(para);

                para = new SqlParameter();
                para.ParameterName = "@Name";
                para.Value = customer.userName;
                para.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(para);

                para = new SqlParameter();
                para.ParameterName = "@Sex";
                para.Value = customer.userName;
                para.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(para);

                para = new SqlParameter();
                para.ParameterName = "@Phone";
                para.Value = customer.userPhone;
                para.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(para);

                para = new SqlParameter();
                para.ParameterName = "@DOB";
                para.Value = customer.dateOfBirth;
                para.SqlDbType = SqlDbType.Date;
                sqlCommand.Parameters.Add(para);

                para = new SqlParameter();
                para.ParameterName = "@Password";
                para.Value = customer.userPassword;
                para.SqlDbType = SqlDbType.VarChar;
                sqlCommand.Parameters.Add(para);

                int retRows = sqlCommand.ExecuteNonQuery();

                return retRows;
            }
        }

        public int LogIn(Customer customer)
        {
            List<Customer> userList = new List<Customer>();

            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();
                string sql = "SP_Select";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SignUp");
                foreach (DataRow i in dataSet.Tables["SignUp"].Rows)
                {
                    Customer user = new Customer(i[4].ToString(), i[5].ToString());
                    userList.Add(user);
                }
            }
            int count = 0;
            foreach (Customer i in userList)
            {
                if (customer.userId == i.userId && customer.userPassword == i.userPassword)
                {
                    count = 1;
                    break;
                }
            }
            userList.Clear();
            return count;
        }
        public DataTable BookBus()
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();
                string sql = "SP_Bus";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void DeleteDetail(int id)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string idQuery = "SP_DeleteDetails";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter();
                para.ParameterName = "@Id";
                para.Value = id;
                para.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(para);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }

        public void UpdateDetail(int id, Bus bus)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string idQuery = "SP_UpdateDetails";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@BusType", bus.BusType);
                sqlCommand.Parameters.AddWithValue("@ATime", bus.arrivalTime);
                sqlCommand.Parameters.AddWithValue("@DTime", bus.departureTime);
                sqlCommand.Parameters.AddWithValue("@Destination", bus.destination);
                sqlCommand.Parameters.AddWithValue("@Fare", bus.rate);
                sqlCommand.Parameters.AddWithValue("@Seats", bus.seats);
                sqlCommand.Parameters.AddWithValue("@Source", bus.source);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertDetail(Bus bus)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string idQuery = "SP_InsertDetails";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter();
                sqlCommand.Parameters.AddWithValue("@BusType", bus.BusType);
                sqlCommand.Parameters.AddWithValue("@ATime", bus.arrivalTime);
                sqlCommand.Parameters.AddWithValue("@DTime", bus.departureTime);
                sqlCommand.Parameters.AddWithValue("@Destination", bus.destination);
                sqlCommand.Parameters.AddWithValue("@Fare", bus.rate);
                sqlCommand.Parameters.AddWithValue("@Seats", bus.seats);
                sqlCommand.Parameters.AddWithValue("@Source", bus.source);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

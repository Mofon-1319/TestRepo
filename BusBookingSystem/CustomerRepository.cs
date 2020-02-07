using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace BusApp
{
    interface iCustomerRepository
    {
        int LogIn(Customer customer);
        int SignUp(Customer customer);
    }
    class CustomerRepository : iCustomerRepository
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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.InsertCommand = sqlCommand;
                int retRows = sqlDataAdapter.InsertCommand.ExecuteNonQuery();

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
                    Customer user = new Customer(i[3].ToString(), i[4].ToString());
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

                string idQuery = "SP_SignUp";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter();
                para.ParameterName = "@UserId";
                para.Value = id;
                para.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(para);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

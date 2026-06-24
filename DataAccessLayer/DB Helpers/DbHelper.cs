using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DB_Helpers
{
    internal class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        // INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string procedureName, params SqlParameter[] parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(procedureName, connection);

            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
                command.Parameters.AddRange(parameters);

            connection.Open();

            return command.ExecuteNonQuery();
        }

        // Scalar Values
        public int ExecuteScalar(string procedureName, Dictionary<string, object> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(procedureName, connection);

            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }

            connection.Open();

            return Convert.ToInt32(command.ExecuteScalar());
        }
       
        
        public async Task<Dictionary<string, object>> GetById(string procedureName,int id)
        {
            
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            Dictionary<string, object> record = new Dictionary<string, object>();
                            foreach (KeyValuePair<string, object> value in reader)
                            {
                                record[value.Key] = value.Value;
                            }
                            return record;
                        }
                        else
                        {
                            return null; // No record found
                        }
                    }
                }

            }


            
        }

        // SELECT
        public DataTable ExecuteDataTable(string procedureName, params SqlParameter[] parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(procedureName, connection);

            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
                command.Parameters.AddRange(parameters);

            using SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Reader
        public SqlDataReader ExecuteReader(string procedureName, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
                command.Parameters.AddRange(parameters);

            connection.Open();

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

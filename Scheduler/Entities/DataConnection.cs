using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Scheduler.Entities
{
    internal class Data_Connections
    {
        //const string connectionString = @"Server=DESKTOP-1FA761O;Database=master;Trusted_Connection=True;";
        const string connectionString = @"Server=DESKTOP-1FA761O;Database=Scheduler;Trusted_Connection=True;";
        //Data Source = DESKTOP - 1FA761O;I
        private SqlConnection sqlConnection = new(connectionString);

        public void ExcuteSQL(string command_text, List<SqlParameter> parameters = null)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.CommandText = command_text;
            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class DBInsert
    {
        public DBInsert(string query)
        {
            insert(query);
        }
        void insert(string query)
        {
            try
            {
                string connectionString =
                @"Data Source = (localdb)\MSSQLLocalDB;" +
                @"AttachDbFilename =" +
                @"C:\Users\amich\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Weather.mdf;" +
                @"Integrated Security = True;" +
                @"Connect Timeout = 30;";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

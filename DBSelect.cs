using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class DBSelect
    {
        double result;
        public DBSelect(string query)
        {
            select(query);
        }
        void select(string query)
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
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!DBNull.Value.Equals(reader[0]))
                    {

                        result = Convert.ToDouble(reader[0]);
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else
                {
                    result = 0;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public double getResult()
        {
            return this.result;
        }
    }
}

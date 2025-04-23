using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace UnitConverterApp
{
    public static class DBHelper
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
        }

        public static void SaveConversion(string type, string fromUnit, string toUnit, double input, double result)
        {
            string query = @"INSERT INTO ConversionHistory 
                            (ConversionType, FromUnit, ToUnit, InputValue, ResultValue, ConvertedAt) 
                            VALUES (@type, @from, @to, @input, @result, NOW())";

            using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@from", fromUnit);
                cmd.Parameters.AddWithValue("@to", toUnit);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@result", result);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

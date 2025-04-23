using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace UnitConverterApp
{
    public partial class Stats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadStats();
        }

        private void LoadStats()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"
                    SELECT ConversionType, COUNT(*) AS TotalConversions
                    FROM ConversionHistory
                    GROUP BY ConversionType
                    ORDER BY TotalConversions DESC";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridViewStats.DataSource = dt;
                    GridViewStats.DataBind();
                }
            }
        }
    }
}

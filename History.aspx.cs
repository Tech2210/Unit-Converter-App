using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace UnitConverterApp
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadHistory();
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        protected void btnClearHistory_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM ConversionHistory";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            // Reload the history after clearing
            LoadHistory();
        }

        private void LoadHistory()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT * FROM ConversionHistory ORDER BY ConvertedAt DESC";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridViewHistory.DataSource = dt;
                    GridViewHistory.DataBind();
                }
            }
        }
    }
}

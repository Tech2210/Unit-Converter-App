using System;
using System.Web.UI;

namespace UnitConverterApp
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSettings();
            }
        }

        private void LoadSettings()
        {
            // Example: Load current settings from session, database, etc.
            // For now, we just load some default settings

            // Theme - Load theme from a session or user profile
            if (Session["UserTheme"] != null)
                ddlThemes.SelectedValue = Session["UserTheme"].ToString();

            // Notification - Load from session/database
            chkEmailNotifications.Checked = true;  // Assuming true for demo
            chkSMSNotifications.Checked = false;   // Assuming false for demo

            // Account Settings - Load from database or session
            txtUsername.Text = "User123";  // Example username

            // Privacy Settings - Load from session/database
            chkAllowDataCollection.Checked = true;  // Assuming true for demo
        }

        protected void btnSaveTheme_Click(object sender, EventArgs e)
        {
            Session["UserTheme"] = ddlThemes.SelectedValue;
            // Optionally update in the database
            Session["SuccessMessage"] = "Settings saved successfully!";
            Response.Redirect("Default.aspx");
        }

        protected void btnSaveNotifications_Click(object sender, EventArgs e)
        {
            bool emailNotifications = chkEmailNotifications.Checked;
            bool smsNotifications = chkSMSNotifications.Checked;
            // Optionally save to the database
            Session["SuccessMessage"] = "Settings saved successfully!";
            Response.Redirect("Default.aspx");
        }

        protected void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            // Optionally update the username in the database
            Session["SuccessMessage"] = "Settings saved successfully!";
            Response.Redirect("Default.aspx");
        }

        protected void btnSavePrivacy_Click(object sender, EventArgs e)
        {
            bool allowDataCollection = chkAllowDataCollection.Checked;
            // Optionally save this value to database
            Session["SuccessMessage"] = "Settings saved successfully!";
            Response.Redirect("Default.aspx");
        }

    }
}

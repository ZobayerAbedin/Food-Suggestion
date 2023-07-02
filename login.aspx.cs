using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Food_Suggestion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logInButtonClick(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            try
            {
                //create new sqlconnection and connection to database by using connection string from web.config file  
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                // Query to insert
                string query = "SELECT COUNT(*) FROM Users WHERE user_name = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                
                int count = (int)cmd.ExecuteScalar();

                // Close the connection
                con.Close();

                if (count > 0)
                {
                    // Success message in alerts
                    Response.Write("<script>alert('Successful login!');</script>");
                    Response.Redirect("~/mid.aspx?name="+ txtName.Text.Trim() +"");
                }
                else
                {
                    Response.Write("<script>alert('Error!');</script>");
                }
            }
            catch (Exception ex)
            {
                // Error message in alerts
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }

        }

        protected void cancelButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }
    }
}
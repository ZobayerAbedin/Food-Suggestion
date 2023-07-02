using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Suggestion
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUpButtonClick(object sender, EventArgs e)
        {
            try
            {
                //create new sqlconnection and connection to database by using connection string from web.config file  
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Users ([user_name], [email], [password]) VALUES(@username, @email, @password)", con);

                cmd.Parameters.AddWithValue("@username", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                
                cmd.ExecuteNonQuery();
                // Close the connection
                con.Close();

                // Success message in alerts
                Response.Write("<script>alert('Account created!');</script>");
                Response.Redirect("~/mid.aspx?name="+ txtName.Text.Trim() +"");
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
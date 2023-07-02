using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Food_Suggestion
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addItemButtonClick(object sender, EventArgs e)
        {
            
            try
            {
                //create new sqlconnection and connection to database by using connection string from web.config file  
                
                SqlConnection con = new SqlConnection(strcon);
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query to insert
                SqlCommand cmd = new SqlCommand("INSERT INTO User_Food ([user_name], [food_name]) VALUES(@userName, @foodName)", con);


                cmd.Parameters.AddWithValue("@userName", Request.QueryString["name"]);
                cmd.Parameters.AddWithValue("@foodName", txtFood.Text.Trim());

                cmd.ExecuteNonQuery();

                // Close the connection
                con.Close();
                
                // Success message in alerts
                Response.Write("<script>alert('Food added!');</script>");
            }
            catch (Exception ex)
            {
                // Error message in alerts
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }
    }
}
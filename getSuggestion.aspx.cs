using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Food_Suggestion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            try
            {
                //create new sqlconnection and connection to database by using connection string from web.config file  
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query to insert
                string query = "select Foods.food_name, carbs, protein, vitamin, mineral " +
                    "from User_food join Foods on User_food.food_name = Foods.food_name" +
                    " WHERE user_name = @username";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@userName", 'b');

                SqlDataReader reader = cmd.ExecuteReader();

                List<string>[] aa = new List<string> [5];
                for (int i = 1; i < 5; i++)
                {
                    aa[i] = new List<string> ();
                }

                while (reader.Read())
                {
                    if (reader.GetDecimal(4) >= 1.5M)
                    {
                        aa[4].Add (reader.GetString(0));
                    }
                    else if (reader.GetDecimal(3) >= 1.5M)
                    {
                        aa[3].Add(reader.GetString(0));
                    }
                    else if (reader.GetDecimal(4) >= 10.0M)
                    {
                        aa[2].Add(reader.GetString(0));
                    }
                    else
                    {
                        aa[1].Add (reader.GetString(0));
                    }

                   
                    Response.Write("<script>alert('" + tmp + "');</script>");

                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                // Error message in alerts
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }
    }
}
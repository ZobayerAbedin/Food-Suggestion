using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Suggestion
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addFoodButtonClick(object sender, EventArgs e)
        {
            String name = Request.QueryString["name"];
            Response.Redirect("~/addFood.aspx?name="+ name +"");
        }

        protected void getSuggestionButtonClick(object sender, EventArgs e)
        {
            String name = Request.QueryString["name"];
            Response.Redirect("~/getSuggestion.aspx?name=" + name + "");
        }
    }
}
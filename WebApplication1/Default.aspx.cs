using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.KisibilgigosterClient kisibilgi = new ServiceReference1.KisibilgigosterClient();
            GridView1.DataSource = kisibilgi.Kisibilgigoster();
            DataBind();


        }
    }
}
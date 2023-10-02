using BilgiYarimasiWEB.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiYarimasiWEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["DogruSayisi"] != null && Session["YanlisSayisi"] != null)
                {
                    int dogruSayisi = (int)Session["DogruSayisi"];
                    int yanlisSayisi = (int)Session["YanlisSayisi"];

                    LBLTrueCount.Text = dogruSayisi.ToString();
                    LBLFalseCount.Text = yanlisSayisi.ToString();
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Sorular.aspx");
        }

    }
}
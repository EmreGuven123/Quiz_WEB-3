using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BilgiYarimasiWEB.Classes;
namespace BilgiYarimasiWEB
{
    public partial class sorudeneme2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandGetRandomData = new SqlCommand("SELECT TOP 1 * FROM Question ORDER BY NEWID()", SqlConnecitonClass.connection);
            SqlCommand commandList = new SqlCommand("Select * from Deneme1", SqlConnecitonClass.connection);

            SqlConnecitonClass.CheckConnection();




            SqlDataReader dr = commandGetRandomData.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            dr.Close();


         //   SqlDataReader dr1 = commandList.ExecuteReader();
           // DataList1.DataSource = dr1;
           // DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
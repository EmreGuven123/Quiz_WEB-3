using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BilgiYarimasiWEB.Classes;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace BilgiYarimasiWEB
{
    
    public partial class ListUye : System.Web.UI.Page
    {

      static  int dogru;
       static int yanlis;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandGetRandomData = new SqlCommand("SELECT TOP 1 * FROM Question ORDER BY NEWID()", SqlConnecitonClass.connection);
            SqlCommand commandList2 = new SqlCommand("Select * from Deneme1", SqlConnecitonClass.connection);
            SqlConnecitonClass.CheckConnection();
            SqlDataReader dr = commandGetRandomData.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();


                dr.Close();
            
            
         
            //SqlDataReader dr1 = commandList2.ExecuteReader();
            //DataList3.DataSource = dr1;
            //DataList3.DataBind();
            //dr1.Close();
        }

       
        

        protected void Button_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)((Button)sender).Parent.FindControl("QuestionText");
            String question = lbl.Text;

          Button btn = (Button)sender;
            String answer = btn.Text;

            String query = String.Format("SELECT TOP 2 * FROM Question WHERE QuestionText LIKE '%{0}%'", question.Replace("\r", "").Replace("\n", "").Replace("'", "''"));
            SqlCommand commandGetRandomData = new SqlCommand(query, SqlConnecitonClass.connection);
            SqlConnecitonClass.CheckConnection();
            SqlDataReader reader1 = commandGetRandomData.ExecuteReader();

            String correctAnswer = "";
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    correctAnswer = reader1.GetString(6);
                   
                }
            }

            if (correctAnswer != "")
            {
                HandleAnswer(correctAnswer == answer);
            
            }
            reader1.Close();         
        }
      

        private void HandleAnswer(Boolean isCorrect)
        {


            if (isCorrect)
                {
                    dogru++;
                    LBLTrue.Text = dogru.ToString();
                }

                else
                {
                   yanlis++;
                  LBLFalse.Text = yanlis.ToString();
                }
            if (dogru + yanlis == 10)
            {
                Session["DogruSayisi"] = dogru; 
                Session["YanlisSayisi"] = yanlis; 

                Response.Redirect("WebForm1.aspx"); 
            }


        }

    }
}
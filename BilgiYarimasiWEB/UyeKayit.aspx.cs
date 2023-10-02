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
    public partial class UyeKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandRegister = new SqlCommand("INSERT INTO Deneme1 (Name, Surname) VALUES (@pname, @pSname)", SqlConnecitonClass.connection);
                SqlConnecitonClass.CheckConnection();
                commandRegister.Parameters.AddWithValue("@pname", tboxName.Text);
                commandRegister.Parameters.AddWithValue("@pSname", tboxSurname.Text);
                int affectedRows = commandRegister.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    Response.Write("Kayıt başarıyla eklendi.");
                }
                else
                {
                    Response.Write("Kayıt eklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Hata: " + ex.Message);
            }
            finally
            {
                SqlConnecitonClass.connection.Close();
            }
            Response.Redirect("Sorular.aspx");
        }
    }
}
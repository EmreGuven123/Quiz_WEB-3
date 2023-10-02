using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BilgiYarimasiWEB.Classes
{
    public class SqlConnecitonClass
    {
        internal static readonly string connectionString;
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G2LV3NG\\SQLEXPRESS;Initial Catalog=BilgiYarismasi;Integrated Security=True");
    public static void CheckConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
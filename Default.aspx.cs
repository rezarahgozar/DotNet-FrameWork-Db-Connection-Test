using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDotNetFrameWork
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTest_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = TebDataSource.Text;
                builder.UserID = TebUserID.Text;
                builder.Password = TebPassword.Text;
                builder.InitialCatalog = TebInitialCatalog.Text;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT TOP 1 * FROM [User]";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));LabMessage
                                LabMessage.Text = "Success !";
                                LabMessage.ForeColor = System.Drawing.Color.Green;

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //Console.WriteLine(ex.ToString());
                LabMessage.Text = "Error !";
                LabMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
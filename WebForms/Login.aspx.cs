using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                int ok = (int)cmd.ExecuteScalar();

                if (ok > 0)
                    Response.Redirect("Shop.aspx");
                else
                    lblMsg.Text = "Pogrešan username ili password!";
            }
        }
    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword2.Text)
            {
                lblMsg.Text = "Passwords do not match!";
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // provjera da username ne postoji
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@u", con);
                checkCmd.Parameters.AddWithValue("@u", txtUsername.Text);

                int postoji = (int)checkCmd.ExecuteScalar();
                if (postoji > 0)
                {
                    lblMsg.Text = "Username already exists!";
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users(UserName, Password, FullName) VALUES (@u, @p, @f)", con);

                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@f", txtFullName.Text);

                cmd.ExecuteNonQuery();
            }

            Response.Redirect("Login.aspx");
        }
    }
}

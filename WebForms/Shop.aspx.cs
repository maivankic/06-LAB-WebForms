using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products(Name, Description) VALUES (@n, @d)", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@d", txtDescription.Text);

                cmd.ExecuteNonQuery();
            }

            lblMsg.Text = "Product added!";

            // refresh grid
            LoadProducts();

            // opcionalno: očisti textboxove
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void LoadProducts()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvProducts.DataSource = dt;
                gvProducts.DataBind();
            }
        }
    }
}

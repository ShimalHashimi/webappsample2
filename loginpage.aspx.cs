using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class loginpage : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitLogin_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('nivin ramzee');</script>");
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_table WHERE usermail = '"+TextBox1.Text+"' AND password = '"+TextBox2.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Session["username"] = dr.GetValue(1);
                    }

                    Response.Redirect("userpage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('invalid');</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
            }
            finally
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }
    }
}
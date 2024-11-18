using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FirstWebApplication
{
    public partial class registerpage : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitSignUp_Click(object sender, EventArgs e)
        {
            if (UserExist())
            {
                Response.Write("<script>alert('Email taken...!');</script>");
            }
            else
            {
                SignUpUser();
            }
        }

        bool UserExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_table WHERE usermail = '"+TextBox1.Text+"';", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

            return false;
        }

        void SignUpUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO user_table(usermail, username, password) VALUES(@UM, @UN, @UP)", con);
                cmd.Parameters.AddWithValue("@UM", TextBox1.Text);
                cmd.Parameters.AddWithValue("@UN", TextBox2.Text);
                cmd.Parameters.AddWithValue("@UP", TextBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Registered successfully...!'); window.location='loginpage.aspx';</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }
    }
}
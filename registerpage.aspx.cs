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
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(TextBox1.Text))
                {
                    TextBox1.BorderColor = System.Drawing.Color.Red; 
                    Label1.Text = "Email is required.";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    isValid = false;
                }
                else
                {
                    TextBox1.BorderColor = System.Drawing.Color.Empty; 
                    Label1.Text = "";
                }

                if (string.IsNullOrWhiteSpace(TextBox2.Text))
                {
                    TextBox2.BorderColor = System.Drawing.Color.Red;
                    Label2.Text = "Username is required.";
                    Label2.ForeColor = System.Drawing.Color.Red;
                    isValid = false;
                }
                else
                {
                    TextBox2.BorderColor = System.Drawing.Color.Empty;
                    Label2.Text = "";
                }

                if (string.IsNullOrWhiteSpace(TextBox3.Text))
                {
                    TextBox3.BorderColor = System.Drawing.Color.Red;
                    Label3.Text = "Password is required.";
                    Label3.ForeColor = System.Drawing.Color.Red;
                    isValid = false;
                }
                else
                {
                    TextBox3.BorderColor = System.Drawing.Color.Empty;
                    Label3.Text = "";
                }

                if (!isValid)
                {
                    return;
                }

                // Database operations
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
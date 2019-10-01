using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    String cardNo;
    String pin;
    String withAmount;
    Boolean isLogin = false;
    string connetionString;
    SqlConnection conn;
    SqlDataAdapter adp = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            connetionString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=ATM_DB; user id = sa; password = Password@123;";
            conn = new SqlConnection(connetionString);
            conn.Open();
            lblstatus.Text = ("Connected");
        }
        catch (Exception ex)
        {
            lblstatus.Text = ("Connection Failed." + ex);
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        cardNo = TextBox1.Text;
        pin = TextBox2.Text;
        withAmount = TextBox3.Text;
        SqlCommand command = new SqlCommand("select * from ATM_DB where atm_num = @param1 AND atm_pin = @param2", conn);

        command.Parameters.AddWithValue("@param1", cardNo);
        command.Parameters.AddWithValue("@param2", pin);
        SqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            if (reader[1].ToString().Equals(pin))
            {
                isLogin = true;
                lblstatus.Text = "Login success";
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox3.Visible = true;
                TextBox1.Visible = false;
            }
            else
            {
                isLogin = false;
                lblstatus.Text = "Login failed";
            }
        }
        else
        {
            lblstatus.Text = "Atm card not present or wrong password";
        }

    }
}
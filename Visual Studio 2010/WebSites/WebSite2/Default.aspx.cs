using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int NPwd = Convert.ToInt32(TextBox1.Text);
            int CPwd = Convert.ToInt32(TextBox2.Text);

            if (NPwd.Equals(CPwd))
            {
                lblstatus.Text = " Password match";
            }
            else
            {
                lblstatus.Text = "Incorrecet Password";
            }
        }
        catch (Exception ex)
        {
            lblstatus.Text = " Insert value first";
        }
    }

}

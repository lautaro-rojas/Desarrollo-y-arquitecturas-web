using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["L"] = TextBox1.Text;
        Session["Ck"] = TextBox1.Text;
        Session["td"] = TextBox1.Text;

        Response.Redirect("Respuesta.aspx");
    }
}
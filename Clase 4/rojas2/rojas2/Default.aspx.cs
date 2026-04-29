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
        Session["Usuario"] = TextBox1.Text;
        Session["Comentario"] = TextBox2.Text;
        Session["Edad"] = TextBox3.Text;

        Response.Redirect("Respuesta.aspx");
    }
}
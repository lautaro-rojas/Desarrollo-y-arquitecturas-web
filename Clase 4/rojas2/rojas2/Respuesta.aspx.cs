using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Respuesta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = Session["Usuario"].ToString();
        Label4.Text = Session["Comentario"].ToString();
        Label6.Text = (int.Parse(Session["Edad"].ToString()) * 12).ToString();
    }
}
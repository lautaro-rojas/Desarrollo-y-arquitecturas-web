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
        if (!IsPostBack) 
        {
            double L = double.Parse(Session["L"].ToString());
            double Ck = double.Parse(Session["Ck"].ToString());
            double td = double.Parse(Session["td"].ToString());

            double K = Math.Pow(L, 3) / (Math.Pow(Ck, 3) * Math.Pow(td, 4));

            Label2.Text = K.ToString();
        }
    }
}
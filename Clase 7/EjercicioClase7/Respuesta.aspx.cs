using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Lun = Session["Lunes"].ToString();
        string Mar = Session["Martes"].ToString();
        string Mie = Session["Miercoles"].ToString();
        string Jue = Session["Jueves"].ToString();
        string Vie = Session["Viernes"].ToString();

        string msj = $"Ud realiza actividades los dias<br>:" + Lun + "<br>" + Mar + "<br>" + Mie + "<br>" + Jue + "<br>" + Vie;

        Label1.Text = msj;
    }
}
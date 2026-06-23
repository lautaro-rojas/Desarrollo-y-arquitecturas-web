using Microsoft.Owin.Security.Cookies;
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

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        //guardo lo del TXT.
        Session["ape"] = txtApe.Text;
        Session["cuota"] = txtCuota.Text;

        //guardo lo del RADIOBUTTON
        Session["beca"] = rbBecado.Checked; //si becado es true, arancelado es false (GroupName PUESTO si o si).

        //guardo lo del CHECKBOX
        Session["lunes"] = chLunes.Checked;
        Session["viernes"] = chViernes.Checked;
        Session["miercoles"] = chMiercoles.Checked;

        //guardo el VALOR del DROPDOWNLIST
        Session["lenguaje"] = DDListLenguaje.SelectedValue; //guarda el valor puesto dentro de la seleccion, en este caso seria "1","2","3"

        Response.Redirect("Default2.aspx");
    }
}
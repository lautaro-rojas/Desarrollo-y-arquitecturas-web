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
        //GUARDO EN COOKIE EL VALOR DEL TXT.
        Response.Cookies["cookie"]["ape"] = txtApe.Text;
        Response.Cookies["cookie"]["cuota"] = txtCuota.Text;
        Response.Cookies["cookie"]["lenguaje"] = DDListLenguaje.SelectedValue;

        if (rbBecado.Checked)
        {
            //GUARDA EL VALOR EN STRING, o sea TRUE/FALSE
            Response.Cookies["cookie"]["beca"] = rbBecado.Checked.ToString();
        }
        else
        {
            //GUARDA EL VALOR EN STRING, o sea TRUE/FALSE
            Response.Cookies["cookie"]["arancelado"]= rbArancelado.Checked.ToString();
        }

        //GUARDA EN COOKIE EL VALOR DEL CHECKBOX (true/false), NO EL STRING DEL CHECKBOX
        Response.Cookies["cookie"]["lunes"] = chLunes.Checked.ToString();
        Response.Cookies["cookie"]["viernes"] = chViernes.Checked.ToString();
        Response.Cookies["cookie"]["miercoles"] = chMiercoles.Checked.ToString();

        Response.Redirect("Default2.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //recupera valores de txts
        string ape = Request.Cookies["cookie"]["ape"];
        float cuota = float.Parse(Request.Cookies["cookie"]["cuota"]);
        string lenguaje = Request.Cookies["cookie"]["lenguaje"];

        //guardamos en variables bool, si fue true pone "true" o sino deja en false 
        bool beca = Request.Cookies["cookie"]["beca"] == "True";
        bool arancelado = Request.Cookies["cookie"]["arancelado"] == "True";
        bool lunes = Request.Cookies["cookie"]["lunes"] == "True";
        bool viernes = Request.Cookies["cookie"]["viernes"] == "True";
        bool miercoles = Request.Cookies["cookie"]["miercoles"] == "True";

        if (beca)
        {
            lblRespuesta.Text = "Sr. " + ape + " Su cuota es GRATIS ya que es Becado.";
        }
        else if (arancelado)
        {
            if (lenguaje == "2")
            {
                if (lunes && viernes)
                {
                    float descuento = (cuota * 70) / 100;
                    lblRespuesta.Text = "Sr. " + ape + " su cuota es del 70% del Valor Enviado, o sea: $" + descuento + " por ser Arancelado e ir los días Lunes y Viernes.";
                }
                else if (lunes || viernes)
                {
                    float descuento1 = (cuota * 80) / 100;
                    lblRespuesta.Text = "Sr. " + ape + " su cuota es del 80% del Valor Enviado, o sea: $" + descuento1 + " por ser Arancelado e ir el día Viernes.";
                }
                else
                {
                    lblRespuesta.Text = "Sr. " + ape + " su cuota es del 100% (sin descuento), o sea: $" + cuota + ".";
                }
            }
            else
            {
                lblRespuesta.Text = "Sr. " + ape + " su cuota es del 100% (sin descuento), o sea: $" + cuota + ".";
            }
        }
    }
}
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
        float cuota;
        string ape, lenguaje;
        bool becado, lunes, viernes, miercoles;
        ape = Session["ape"].ToString();
        cuota = float.Parse(Session["cuota"].ToString());
        becado = (bool)Session["beca"]; //si tiene algo, lo pasa a bool
        if (Session["lunes"] != null)
        {
            lunes = (bool)Session["lunes"];//si tiene algo, lo pasa a bool
        }
        else
        {
            lunes = false; //si no tiene nada lo pasa a false.
        }
        if (Session["viernes"] != null)
        {
            viernes = (bool)Session["viernes"];
        }
        else
        {
            viernes = false;
        }
        if (Session["miercoles"] != null)
        {
            miercoles = (bool)Session["miercoles"];
        }
        else
        {
            miercoles = false;
        }
        lenguaje = Session["lenguaje"].ToString(); //GUARDO el VALOR de lo SELECCIONADO, NO EL NOMBRE
        if (becado)
        {
            lblRespuesta.Text = $"Sr. {ape} su cuota es GRATIS ya que es Becado.";
        }
        else
        {
            if (lenguaje == "2") //valor de Python
            {
                if (lunes && viernes) //si lunes y viernes es true
                {
                    float Total = (cuota * 70) /100;
                    lblRespuesta.Text = $"Sr. {ape} su cuota es del 70% del Valor Enviado, o sea: ${Total} por ser Arancelado, hacer Python e ir los días Lunes y Viernes.";
                }
                else if (lunes || viernes) //uno de los dos es true, LOS DOS NO
                {
                    float total = (cuota * 80) / 100;
                    lblRespuesta.Text = $"Sr. {ape} su cuota es del 80% del Valor Enviado, o sea: ${total} por ser Arancelado e ir un día solo.";
                }
                else if(miercoles)
                {
                    lblRespuesta.Text = $"Sr. {ape} su cuota es del 100%, o sea: ${cuota} por cursar Python en días no promocionados.";
                }
            }
            else
            {
                lblRespuesta.Text = $"Sr. {ape} su cuota es del 100%, o sea: ${cuota}";
            }
        }
    }
}
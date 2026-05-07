using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioClase5
{
    public partial class Respuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double preciodia = 0;
            double preciototal = 0;

            preciodia = Convert.ToDouble(Session["PrecioBase"]) + (Convert.ToDouble(Session["PrecioBase"]) * Convert.ToDouble(Session["Multiplicador"]));
            preciototal = preciodia * Convert.ToDouble(Session["CantDias"]) * Convert.ToDouble(Session["CantPers"]);

            Label1.Text = Session["Destino"] + " - " + Session["Categoria"] + " - " + Session["CantDias"] + " días - " + Session["CantPers"] + " personas - Precio total: $" + preciototal;
        }
    }
}
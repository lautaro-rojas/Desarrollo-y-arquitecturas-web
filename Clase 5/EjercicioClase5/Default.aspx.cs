using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioClase5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double preciobase = 0;
            double multiplicador = 0;

            Session["Destino"] = RadioButtonList1.SelectedItem.Text;
            Session["Categoria"] = RadioButtonList2.SelectedItem.Text;
            Session["CantDias"] = TextBox_CantDias.Text;
            Session["CantPers"] = TextBox_CantPers.Text;
            

            if (RadioButtonList1.SelectedItem.Text == "Mar del plata")
            {
                preciobase = 100;
            }
            else if (RadioButtonList1.SelectedItem.Text == "Niza")
            {
                preciobase = 400;
            }

            if (RadioButtonList2.SelectedItem.Text == "3 estrellas")
            {
                multiplicador = 0.011;
            }
            else if (RadioButtonList2.SelectedItem.Text == "4 estrellas")
            {
                multiplicador = 0.013;
            }

            Session["PrecioBase"] = preciobase;
            Session["Multiplicador"] = multiplicador;

            Response.Redirect("Respuesta.aspx");
        }
    }
}
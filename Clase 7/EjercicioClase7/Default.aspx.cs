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
        Session["Lunes"] = "";
        Session["Martes"] = "";
        Session["Miercoles"] = "";
        Session["Jueves"] = "";
        Session["Viernes"] = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Session["Lunes"] = CheckBox1.Text;
        }

        if (CheckBox2.Checked == true)
        {
            Session["Martes"] = CheckBox2.Text;
        }

        if (CheckBox3.Checked == true)
        {
            Session["Miercoles"] = CheckBox3.Text;
        }

        if (CheckBox4.Checked == true)
        {
            Session["Jueves"] = CheckBox4.Text;
        }

        if (CheckBox5.Checked == true)
        {
            Session["Viernes"] = CheckBox5.Text;
        }

        Response.Redirect("Respuesta.aspx");

    }
}
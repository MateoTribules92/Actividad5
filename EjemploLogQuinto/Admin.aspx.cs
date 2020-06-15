using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploLogQuinto
{
    public partial class Admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (Session["admin"] != null)
            {
                lbl_mensaje.Text += Session["admin"].ToString();
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
        }

        protected void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("/Login.aspx");
        }
    }
}
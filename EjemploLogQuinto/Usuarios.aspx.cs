using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploLogQuinto
{
    public partial class Usuarios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (Session["usu"] != null)
            {
                lbl_mensaje.Text += Session["usu"].ToString();
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }

            TextBox1.Attributes.Add("onkeypress", "javascript:return SoloNum(event); ");
            TextBox3.Attributes.Add("onkeypress", "javascript:return SoloNum(event); ");
            TextBox2.Attributes.Add("onkeypress", "javascript:return SoloNum(event); ");

        }

        protected void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Session["usu"] = null;
            Response.Redirect("/Login.aspx");
        }

        private bool Validar(string dato)
        {
            if (dato != "")
                return true;

            else
                return false;
        }
        private bool Validar2(string dato2)
        {
            if (dato2 != "")
                return true;

            else
                return false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Validar(TextBox1.Text))//envias el textbox que queres comprobar
            {
                Response.Write("DEBE LLENAR EL Primer Numero");
            }

            
            else
            {
                if (!Validar2(TextBox2.Text))//envias el textbox que queres comprobar
                {
                    Response.Write("DEBE LLENAR EL Segundo Numero");
                }
                else
                {
                    double a = Convert.ToDouble(TextBox1.Text);
                    double b = Convert.ToDouble(TextBox2.Text);
                    double c;


                    c = a + b;


                    TextBox3.Text = c.ToString();
                  
                    
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!Validar(TextBox1.Text))//envias el textbox que queres comprobar
            {
                Response.Write("DEBE LLENAR EL Primer Numero");
            }

            
            else
            {
                if (!Validar2(TextBox2.Text))//envias el textbox que queres comprobar
                {
                    Response.Write("DEBE LLENAR EL Segundo Numero");
                }
                else
                {

                    double m = Convert.ToDouble(TextBox1.Text);
                    double m2 = Convert.ToDouble(TextBox2.Text);
                    double c;
                    c = m - m2;
                    TextBox3.Text = c.ToString();
                    
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (!Validar(TextBox1.Text))//envias el textbox que queres comprobar
            {
                Response.Write("DEBE LLENAR EL Primer Numero");
            }

            
            else
            {
                if (!Validar2(TextBox2.Text))//envias el textbox que queres comprobar
                {
                    Response.Write("DEBE LLENAR EL Segundo Numero");
                }
                else
                {
                    double m = Convert.ToDouble(TextBox1.Text);
                    double m2 = Convert.ToDouble(TextBox2.Text);
                    double c;
                    c = m * m2;
                    TextBox3.Text = c.ToString();
                    
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (!Validar(TextBox1.Text))//envias el textbox que queres comprobar
            {
                Response.Write("DEBE LLENAR EL Primer Numero");
            }

            
            else
            {
                if (!Validar2(TextBox2.Text))//envias el textbox que queres comprobar
                {
                    Response.Write("DEBE LLENAR EL Segundo Numero");
                }
                else
                {

                    double m = Convert.ToDouble(TextBox1.Text);
                    double m2 = Convert.ToDouble(TextBox2.Text);
                    double c;
                    c = m / m2;
                    TextBox3.Text = c.ToString();
                    
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}
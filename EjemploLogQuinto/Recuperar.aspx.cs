using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using CapaDatos;
using CapaNegocio;
using System.Net.Mail;
using System.Net;

namespace EjemploLogQuinto
{
    public partial class Recuperar1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
        }

        //metodo para recuperar password

        public void recuperar()
        {
            //cajas de texto vacias
            lbl_error.Visible = false;
            if (string.IsNullOrEmpty(txt_Usuario_Recuperar.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Ingrese su Usuario";
                return;
            }

            //validacion de correo
           
            bool existemail = CapaNegocio.LogicaUsuario.autentificarEmail(txt_Usuario_Recuperar.Text);
             
            
            {
                if (existemail)
                {
                    if (true)
                    {

                        MailMessage email = new MailMessage();
                        email.From = new MailAddress("mateo.tribules.1999@gmail.com");
                        email.To.Add(txt_Usuario_Recuperar.Text);
                        email.Subject = ("Recuperar Contraseña");
                        email.Body = "Ha solicitado la recuperacion de su Contraseña:"  ;
                        email.Priority = MailPriority.Normal;

                        SmtpClient server = new SmtpClient();
                        server.Credentials = new NetworkCredential("mateo.tribules.1999@gmail.com", "Tribules2810212");
                        server.Host = "smtp.gmail.com";
                        server.Port = 587;
                        server.EnableSsl = true;
                        try
                        {
                            server.Send(email);
                            lbl_envio.Visible = true;
                            lbl_envio.Text = "Correo enviado con exito!";
                        }
                        catch (Exception)
                        {
                            lbl_error.Visible = true;
                            lbl_error.Text = "Correo no enviado";
                        }
                    }
                 
                }
                else
                {
                    lbl_error.Visible = true;
                    lbl_error.Text = "Usuario no existente";
                    return;
                }



            }
        }
    

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            recuperar();

        }
    }
}
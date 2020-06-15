using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using CapaDatos;
using CapaNegocio;

namespace EjemploLogQuinto
{
    public partial class Login1 : System.Web.UI.Page
    {

        int contador = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            Session["con"] = Session["contantiguo"];
        }

        //metodo para ingresar

        public void ingresar()
        {
            //cajas de texto vacias
            lbl_mensaje.Visible = false;
            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Ingrese su Nombre";
                return;
            }
            if (string.IsNullOrEmpty(txt_Pass.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Ingrese su Clave";
                return;
            }

        

            //validar los perfiles de usuario
            bool existe = CapaNegocio.LogicaUsuario.Auntentificar(txt_Usuario.Text, txt_Pass.Text);
            bool existenom = CapaNegocio.LogicaUsuario.autentificarNom(txt_Usuario.Text);
            {
                if (existenom)
                {


                    if (existe)
                    {
                        //instancia mi tabla como objeto
                        Tbl_Usuarios usuario = new Tbl_Usuarios();
                        usuario = LogicaUsuario.Autentificarxlogin(txt_Usuario.Text, txt_Pass.Text);

                        //validar si es admin o usuario 

                        int tusuario = usuario.TUsu_id;
                        if (tusuario == 1)
                        {
                            Session["Admin"] = txt_Usuario.Text;
                            Response.Redirect("/Admin.aspx");



                        }

                        if (tusuario == 2)
                        {
                            Session["Usu"] = txt_Usuario.Text;
                            Response.Redirect("/Usuarios.aspx");
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "!Datos Incorrectos";
                        lbl_intentos.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                        Session["contantiguo"] = lbl_intentos.Text.ToString();
                        if (Convert.ToInt32(lbl_intentos.Text) == 3)
                        {
                            btn_Entrar.Enabled = false;
                            Session["con"] = null;
                            Session["contantiguo"] = null;
                        }
                    }
                }
                else
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "Usuario no existente";
                }
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

            ingresar();

        }

        protected void btn_olvido_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recuperar.aspx");
        }

        protected void lnk_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recuperar.aspx");
        }
    }
}
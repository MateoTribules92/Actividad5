using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;
using System.Net.Mail;
using System.Net;

namespace CapaNegocio
{

    public class LogicaUsuario
    {
        //instanciar el data contex

        public static DataClasses1DataContext dc = new DataClasses1DataContext();

        //crear un metodo para retornar los datos 

        public static List<Tbl_Usuarios> obtenerUsuarios()

        {
            var lista = dc.Tbl_Usuarios.Where(usu => usu.usu_estado == 'A');
            //es como es select * from 
            return lista.ToList();

        }


        public static List<Tbl_Usuarios> obtenerPassword( string email, string pass)
        {
            var password = dc.Tbl_Usuarios.Where(usu => usu.usu_estado == 'A'
            & usu.usu_correo.Equals(email) & usu.usu_contraseña.Equals(pass));

            return password.ToList();

        }
    

        //metodo para verificar credenciales

        public static bool Auntentificar(string nombre, string pass)
        {
            var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A'
            & usu.usu_nomlogin.Equals(nombre) & usu.usu_contraseña.Equals(pass));

            return auto;
        }

        //crear metodo para verificar el nombre login 
        
        public static bool autentificarNom(string nombre)
        {
            var auton = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A' &
            usu.usu_nomlogin.Equals(nombre));

            return auton;
        }

        //metodo para verificar el e-mail

        public static bool autentificarEmail(string mail)
        {
            var correo = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A' &
            usu.usu_correo.Equals(mail));

            return correo;
        }

        //metodo para verificar usuarios en especificas credenciales

        public static Tbl_Usuarios Autentificarxlogin (string nombre, string pass)
        {
            var nlogin = dc.Tbl_Usuarios.Single(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre) &
            usu.usu_contraseña.Equals(pass));

            return nlogin;
        }

        //autentificar cedula 

        public static bool autetinficarced (string ced)
        {
            var autoc = dc.Tbl_Usuarios.Any(usu => usu.usu_cedula.Equals(ced));

            return autoc;
        }

        //metodo para guardar datos 

        public static void save(Tbl_Usuarios usuario)
        {
            try
            {
                //guardar la informacion quemada
                usuario.usu_estado = 'A';
                usuario.usu_fechacreacion = DateTime.Now;
                //guardamos el objeto en la base de datos
                dc.Tbl_Usuarios.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los datos no han sido guardados </br>" + ex.Message);
            }
        }

        //metodo para recuperar password

      

    }
}

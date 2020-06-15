using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{
    public class LogicaTipoUsuario
    {
        //instanciar el data contex

        public static DataClasses1DataContext dc = new DataClasses1DataContext();

        //metodo para obtener toda la informacion de la entidad

        public static List<Tbl_TipoUsuario> obtenerTusuarios()
        {
            var lista = dc.Tbl_TipoUsuario.Where(tusu => tusu.TUsu_estado == 'A');
            //es como es select * from 
            return lista.ToList();


        }
    }
}

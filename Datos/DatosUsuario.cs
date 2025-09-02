using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosUsuario
    {
        public int LoginUsuario(Usuario usuario)
        {
            string conexionstring = "server=DESKTOP-T49EB1I\\SQLEXPRESS; database=loginapp; integrated security=true";
            SqlConnection con = new SqlConnection(conexionstring);
            int flag = 0;
            con.Open();
            string query = "select count(*) from usuarios where DNI = " + usuario.DNI + " AND clave = '" + usuario.clave + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return flag;
        }
    }
}

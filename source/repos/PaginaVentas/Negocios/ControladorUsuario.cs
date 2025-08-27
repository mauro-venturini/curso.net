using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ControladorUsuario
    {
        DatosUsuario Dusuario = new DatosUsuario();
        public int CrearUsuario(Usuario usuario)
        {
            return Dusuario.LoginUsuario(usuario);
        }
    }
}

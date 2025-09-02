using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : Utilidad
    {
        ControladorUsuario usuarioManager = new ControladorUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            var dni = txtUsuario.Text;
            var clave = txtClave.Text;
            Usuario usu = new Usuario();
            usu.DNI = int.Parse(dni);
            usu.clave = clave;
            var res = usuarioManager.LoginUsuario(usu);
            if (res != 0)
            {
                MsgBox("el susuario existe");
            }
            else {
                MsgBox("no existis gilardinho");
            }



        }

    }
}
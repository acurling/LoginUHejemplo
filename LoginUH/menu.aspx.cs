using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUH
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario(); 

            lusuario.Text = "Bienvenido al sistema" + " " + clsUsuario.nombre;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUH
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            clsUsuario.email = tusuario.Text;   // Pedro
            clsUsuario.clave = tclave.Text;     // 123

            ValidarUsuario(clsUsuario.email, clsUsuario.clave);
            
        }


        protected void ValidarUsuario(string correo, string contrasena)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select email, clave, nombre from usuarios where email = '" + correo + "' " +
                "and clave = '" + contrasena + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                clsUsuario.nombre = registro[2].ToString();
                Response.Redirect("menu.aspx");
            }
            else
            {
                //Lmensaje.Text = " usuario o contraseña incorrecto";
            }
            conexion.Close();
        }
    }
}
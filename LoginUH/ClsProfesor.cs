using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginUH
{
   
    public class ClsProfesor
    {
        private static int  curso { get; set; } // tipo de variable globales
        public static string nombre { get; set; }  // variable globales
        public void consultar()
        {
            
        }

        public void agregar()

        {
         DateTime fecha = DateTime.Now;  // tipo de variable local
            curso = 0;
            nombre = "nombre profesor";
        }

        public void borrar()
        {
            
            curso = 0;
            nombre = "nombre profesor";
        }
    }
}
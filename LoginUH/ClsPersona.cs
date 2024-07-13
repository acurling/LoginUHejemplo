using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginUH
{
    public class ClsPersona
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono  { get; set; }


        protected static void agregarpersona() { }
    }
}
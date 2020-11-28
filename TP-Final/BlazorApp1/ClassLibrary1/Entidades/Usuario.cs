using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Usuario
    {
        public int UsuarioPK { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}



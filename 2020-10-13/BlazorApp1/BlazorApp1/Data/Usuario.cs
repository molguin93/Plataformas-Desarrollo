using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Text;

namespace BlazorApp1.Data
{
    public class Usuario
    {
        public int UsuarioPK { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}

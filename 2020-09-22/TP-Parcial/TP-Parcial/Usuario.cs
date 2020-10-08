using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TP_Parcial
{
    // Clase hecha con DataNotations

    //[Table("User")] // por defecto entity pluralisa el nombre de la clase para darle nombre a la tabla, con esto le pongo el nombre que quiero.
    //public class Usuario
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    [MaxLength(50)]
    //    [MinLength(10)]
    //    public string Nombre { get; set; }
    //    [Required]
    //    [Column("Password")]  // le cambio el nombre de la columna en la tabla.
    //    public string Clave { get; set; }

    //    [NotMapped] // no la busca en la tabla de la base de datos.
    //    public string Imagen { get; set; }
    //}

    public class Usuario
    {
        public int UsuarioPK { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}

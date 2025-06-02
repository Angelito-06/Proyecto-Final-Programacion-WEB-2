using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Necli.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        public required string Tipo_Usuario { get; set; }
        public required string Contraseña { get; set; }
        public required string Nombres_Usuario { get; set; }
        public required string Apellidos_Usuario { get; set; }
        public required string Cedula { get; set; }
        public required string Correo { get; set; }
        public required DateTime Fecha_Nacimiento { get; set; }

        public Cuenta Cuenta { get; set; }
    }
}

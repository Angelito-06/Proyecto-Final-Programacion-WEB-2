using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Necli.Estidades
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres_Usuario { get; set; }
        public string Apellidos_Usuario { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public Cuenta cuenta { get; set; }
    }
}

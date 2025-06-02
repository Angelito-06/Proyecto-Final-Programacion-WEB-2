using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Necli.Estidades
{
    public class Cuenta
    {
        [Key]
        public int IdCuenta { get; set; }
        public string Nombre_Titular { get; set; }
        public DateTime Fecha_Creracion { get; set; }
        public decimal Saldo { get; set; }
        public string Telefono { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Necli.Estidades
{
    public class Transaccion
    {
        [Key]
        public int Id_Transaccion { get; set; }
        public required DateTime Fecha_Transaccion { get; set; }
        public decimal Monto { get; set; }
        public required string Tipo_Transaccion { get; set; }
        [Required]
        public int Id_CuentaOrigen { get; set; }
        public string Cuenta_Origen { get; set; }
        [Required]
        public int Id_CuentaDestino { get; set; }
        public Cuenta Cuenta_Destino { get; set; }
    }
}

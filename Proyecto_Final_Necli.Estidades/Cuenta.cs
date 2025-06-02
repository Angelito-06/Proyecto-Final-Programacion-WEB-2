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
        public required string Nombre_Titular { get; set; }
        public required DateTime Fecha_Creracion { get; set; }
        public required decimal Saldo { get; set; }
        public required string Telefono { get; set; }
        public required int Usuario_Id { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<Transaccion> Transacciones_Origen{ get; set; }
        public ICollection<Transaccion> Transacciones_Destino { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Necli.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Necli.Persistencia.DbContext
{
    public class Pf_NecliDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

        public Pf_NecliDbContext(DbContextOptions<Pf_NecliDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

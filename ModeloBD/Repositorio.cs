using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio : DbContext
    {
        public DbSet<Bono> Bonos { get; set; }
        public DbSet <Cargo> Cargos { get; set; }
        public DbSet<Control_Asistencia> Control_Asistencias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DesempenoSc> DesempenoSc { get; set; }
        public DbSet<DesempenoEm> desempenoEm { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Horario_Det> Horario_Dets { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }
        public DbSet<Sueldo> Sueldos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V7VPQBI;Initial Catalog=SisEvalV2;Trusted_Connection=True");
        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Departamento)
                .WithMany(c => c.)
        }
        */
    }
}

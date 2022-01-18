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
        public DbSet<Bonos> Bonos { get; set; }
        public DbSet <Cargo> Cargos { get; set; }
        public DbSet<Control_Asistencia> Control_Asistencias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Desempeno> Desempenos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Horario_Det> Horario_Dets { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }
        public DbSet<Sueldo> Sueldos { get; set; }
    }
}

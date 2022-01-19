using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Departamento Departamentos { get; set; }
        public int DepartamendoId { get; set; }
        public Sucursal Sucursales { get; set; }
        public int SucursalId { get; set; }
        public Control_Asistencia Asistencias { get; set; }
        public int AsistenciaId { get; set; }

        /*
        public Cargo Cargos { get; set; }
        public int CargoId { get; set; }
        public Factura Facturas { get; set; }
        public int FacturaId { get; set; }
        public Permiso Permisos { get; set; }
        public int PermisoId { get; set; }
        
        public Desempeno DesempenosA { get; set; }
        public int DesempenoId { get; set; }
        public Bono Bonos { get; set; }
        public int BonoId { get; set; }        
        public Sueldo Sueldos { get; set; }
        public int SueldoId { get; set; }
        */
    }
}

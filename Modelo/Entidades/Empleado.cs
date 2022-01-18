using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empleado
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamendoId { get; set; }
        public Sucursal Sucursal { get; set; }
        public int SucursalId { get; set; }
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }
        public Facturas Facturas { get; set; }
        public int FacturaId { get; set; }
        public Permisos Permisos { get; set; }
        public int PermisoId { get; set; }
        public Control_Asistencia Asistencia { get; set; }
        public int AsistenciaId { get; set; }
        public Desempeno Desempeno { get; set; }
        public int DesempenoId { get; set; }
        public Sueldo Sueldo { get; set; }
        public int SueldoId { get; set; }
    }
}

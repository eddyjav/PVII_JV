using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Control_Asistencia
    {
        public int Control_AsistenciaId { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime SalidaAlmuerzo { get; set; }
        public DateTime EntradaAlmuerzo { get; set; }
        public DateTime Salida { get; set; }
        //public string Permiso { get; set; }

        //public Horario_Det Horario_Det{ get; set; }
       
        public ICollection<Permiso> Permisos  { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}

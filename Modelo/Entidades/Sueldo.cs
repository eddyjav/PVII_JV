using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Sueldo
    {
        public int SueldoId { get; set; }
        public float SueldoBase { get; set; }
        public Empleado Empleados { get; set; }
        public int EmpleadoId { get; set; }
        public Cargo CargoS { get; set; }
        public int CargoId { get; set; }
        public Factura Facturas { get; set; }
        public int FacturasId { get; set; }
        public Bono Bonos { get; set; }
        public int BonoId { get; set; }
        public DesempenoSc desempenoScs { get; set; }
        public int DesempenoScId { get; set; }
        public DesempenoEm DesempenoEms { get; set; }
        public int DesempenoEmId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Bono
    {
        public int BonoID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public float Valor { get; set; }


        /*public ICollection<Sueldo> LSueldo{ get; set; }
        */
        /*
        public Factura Factura { get; set; }
        public int FacturaId { get; set; }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class ImpuestoCirculacion : Impuesto
    {
        public override double calcular(double monto)
        {
            double costo = 0;

            costo = monto * 0.075;

            return costo;
        }

        public string toString()
        {
            return "Impuesto de Circulacion";
        }
    }
}

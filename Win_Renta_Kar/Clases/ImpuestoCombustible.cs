using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class ImpuestoCombustible : Impuesto
    {
        public override double calcular(double monto)
        {
            double costo = 0;

            costo = monto * 0.055;

            return costo;
        }

        public string toString()
        {
            return "Impuesto de Combustible";
        }
    }
}

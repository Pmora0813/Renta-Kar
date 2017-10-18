using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class Asistncia : ISeguro
    {
        public string Decripcion
        {
            get
            {
                return "Asistncia";
            }
        }
        public double Calcular_Costo(double monto)
        {
            double costo = 0;

            costo = monto * 0.0335;

            return costo;
        }
    }
}

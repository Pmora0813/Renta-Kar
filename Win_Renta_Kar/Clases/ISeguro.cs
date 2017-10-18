using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    interface ISeguro
    {
        string Decripcion { get; }
        double Calcular_Costo(double monto);
    }
}

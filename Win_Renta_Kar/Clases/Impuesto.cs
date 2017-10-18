using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
   abstract class Impuesto
    {
        abstract public double calcular(double monto);
    }
}

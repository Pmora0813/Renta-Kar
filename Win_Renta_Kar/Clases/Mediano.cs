using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class Mediano : ITipoVeiculo
    {
        public double Costo_Por_Dia
        {
            get
            {
                return 33;
            }
        }
        public string Nombre
        {
            get
            {
                return "Mediano";
            }
        }
    }
}
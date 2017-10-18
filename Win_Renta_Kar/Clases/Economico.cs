using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class Economico : ITipoVeiculo
    {
        public double Costo_Por_Dia
        {
            get
            {
                return 21;
            }
        }
        public string Nombre
        {
            get
            {
                return "Economico";
            }
        }
    }
}

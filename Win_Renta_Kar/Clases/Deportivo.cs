using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class Deportivo : ITipoVeiculo
    {
        public double Costo_Por_Dia
        {
            get
            {
                return 55;
            }
        }
        public string Nombre
        {
            get
            {
                return "Deportivo";
            }
        }
    }
}

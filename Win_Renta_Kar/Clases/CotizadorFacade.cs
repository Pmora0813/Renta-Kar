using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class CotizadorFacade
    {
        private Cliente cliente;
        private List<Extras> Lista_extras;
        private List<Impuesto> Lista_Impuesto;
        private List<ISeguro> Lista_ISeguro;

        private DateTime FechaInicio { get; set; }
        private DateTime FechaFinal { get; set; }
        private ITipoVeiculo tipoVeiculo { get; set; }

        public CotizadorFacade()
        {
            this.cliente = null;
            Lista_extras = new List<Extras>();
            Lista_Impuesto = new List<Impuesto>();
            Lista_ISeguro = new List<ISeguro>();
        }

        public void AgregarCliente(String email, string nombre)
        {
            cliente = new Cliente(email, nombre);
        }

        public void AgregarExtras(Extras extras)
        {
            Lista_extras.Add(extras);
        }

        public void AgregarImpuesto(Impuesto impuesto)
        {
            Lista_Impuesto.Add(impuesto);
        }
        public void AgregarSeguro(ISeguro seguro)
        {
            Lista_ISeguro.Add(seguro);
        }

        public int Calcular_Dias()
        {
            int dias = 0;
            dias = (FechaFinal - FechaInicio).Days;
            return dias;
        }

        //Regla 1

        public double total_Costo_Dias()
        {
            double costo = 0;

            costo = Calcular_Dias() * tipoVeiculo.Costo_Por_Dia;

            return costo;
        }

        //Regla 2
        public double total_Extras()
        {
            double costo = 0;
            int dias = Calcular_Dias();

            foreach (Extras ex in Lista_extras)
            {
                if (ex == Extras.WIFI)
                {
                    costo += 0.085 * dias;
                }

                if (ex == Extras.GPS)
                {
                    costo += 0.1375 * dias;
                }

                if (ex == Extras.BOOSTER)
                {
                    costo += 0.1999 * dias;
                }


            }
            return costo;

        }
        //Regla 3
        public double total_Porc_Seguros()
        {
            double costo = 0;

            double monto = total_Costo_Dias();

            foreach (ISeguro seg in Lista_ISeguro)
            {
                costo += seg.Calcular_Costo(monto);
            }
            return costo;
        }

        //Regla 4
        public double total_Porc_Impuesto()
        {
            double costo = 0;
            double monto = total_Costo_Dias();

            foreach(Impuesto imp in Lista_Impuesto)
            {
                costo += imp.calcular(monto);
            }

            return costo;
        }

        public double Calcular_Total()
        {
            double costo = 0;
            costo = total_Costo_Dias() + total_Extras() + total_Porc_Seguros() + total_Porc_Impuesto();
            return costo;
        }

    }
}

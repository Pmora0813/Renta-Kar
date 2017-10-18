using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Renta_Kar
{
    class Cliente
    {
        private string email { get; set; }
        private string nombre { get; set; }

        public Cliente(string email, string nombre)
        {
            this.email = email;
            this.nombre = nombre;
        }

    }
}

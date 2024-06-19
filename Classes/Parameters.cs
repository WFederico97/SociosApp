using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociosApp.Classes
{
    public class Parameters
    {
        public string nombre { get; set; }
        public object valor { get; set; }

        public Parameters(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}

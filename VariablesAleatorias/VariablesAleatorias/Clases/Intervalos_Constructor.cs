using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAleatorias.Clases
{
    public class Intervalos_Constructor
    {
        public double maximo_int { get; set; }
        public double minimo_int { get; set; }

        public string get_intervalo()
        {
            return "[" + minimo_int + " - " + maximo_int + "]";
        }


    }
}
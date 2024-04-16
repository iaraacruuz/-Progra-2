using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    public class Calculadora
    {
        public static int CalcularDias(DateTime fecha)
        {
            //time span es un tipo de dato que representa un intervalo de tiempo (desde-hasta)
            //en este caso es el intervalo entre dos fechas.
            TimeSpan diasPasados;
            DateTime fechaActual= DateTime.Now;
            //diasPasados = fechaActual- fecha; es lo mismo que lo de abajo:
            diasPasados = fechaActual.Subtract(fecha);
            return diasPasados.Days;


        }
    }
}

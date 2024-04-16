using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    public class StringBuilder
    {

        public static string tablaMultiplicacion(int numero)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return sb.ToString();

        }
    }
}

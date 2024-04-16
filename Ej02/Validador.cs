using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Validador
    {
       public static bool ValidarRespuesta( string respuesta)
        {
            return respuesta.ToUpper() == "S";

        }
    }
}

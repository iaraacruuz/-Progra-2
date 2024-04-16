using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    public class Calculadora
    {
        public static int Calculador(int primerOperando, int segundoOperando, int operacionMatematica)
        {
            switch(operacionMatematica)
            {
                case 1:
                    return primerOperando + segundoOperando;
                case 2:
                    return primerOperando - segundoOperando;
                case 3:
                    return primerOperando * segundoOperando;
                case 4:
                    if(segundoOperando!=0)
                    {
                        return primerOperando / segundoOperando;
                    }
                    else
                        throw new DivideByZeroException("Error: División por cero.");
                default:
                    throw new ArgumentException("Error: Operación matemática no válida.");



            }

        }

        private static bool Validar(int segundoOperando)
        {
            if(segundoOperando!=0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool ValidarDivision(int segundoOperando)
        {
            return Validar(segundoOperando);
        }
    }


   
}

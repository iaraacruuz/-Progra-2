using System.Security.Cryptography.X509Certificates;

namespace Ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Por favor ingresa la operación deseas realizar ingresando el caracter: +, -, * o /");
                char operacion;
                if (!char.TryParse(Console.ReadLine(), out operacion) || !EsOperacionValida(operacion))
                {
                    Console.WriteLine("Operación no válida. Por favor ingresa una operacion valida (+, -, *, /).");
                    continuar = false;
                    continue;
                }

                Console.WriteLine("Por favor ingresa el primer numero de la operación (operando):");
                string primerNumeroStr = Console.ReadLine();
                int primerNumero;
                if (!int.TryParse(primerNumeroStr, out primerNumero))
                {
                    Console.WriteLine("Por favor ingresa un numero valido");
                    continue;
                }

                Console.WriteLine("Por favor ingresa el segundo número de la operacion (operador):");
                string segundoNumeroStr = Console.ReadLine();
                int segundoNumero;
                if (!int.TryParse(segundoNumeroStr, out segundoNumero))
                {
                    Console.WriteLine("Por favor ingresa un número valido.");
                    continue;
                }

                // Llamamos al método estático obtenerCodigoOperacion para obtener el código de la operación
                int codigoOperacion = obtenerCodigoOperacion(operacion);

                try
                {
                    // Validamos la división por cero utilizando el método privado Validar de la clase Calculadora
                    if (operacion == '/' && !Calculadora.ValidarDivision(segundoNumero))
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        continuar = false;
                        continue;
                    }

                    
                    int resultado = Calculadora.Calculador(primerNumero, segundoNumero, codigoOperacion);
                    Console.WriteLine($"El resultado de la operación es: {resultado}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("¿Desea realizar otra operación? (S/N)");
                string respuesta = Console.ReadLine();
                continuar = (respuesta == "S");
            }
        }

        
        private static int obtenerCodigoOperacion(char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return 1;
                case '-':
                    return 2;
                case '*':
                    return 3;
                case '/':
                    return 4;
                default: //me sugirio tirar esta excepcion chat gpt
                    throw new ArgumentException("Error: Operacion no valida");
            }
        }

      
        private static bool EsOperacionValida(char operacion)
        {
            return operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/';
        }




    
    
    }
}

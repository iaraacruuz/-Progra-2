namespace Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int suma = 0;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;

            while (contador < 10)
            {
                Console.WriteLine($"Ingrese el numero: {contador + 1}");
                string ingreso = Console.ReadLine();

                if (int.TryParse(ingreso, out int numero))
                {
                    if (Validador.Validar(numero, -100, 100))
                    {
                        suma += numero;
                        if (numero < valorMinimo)
                        {
                            valorMinimo = numero;
                        }
                        if (numero > valorMaximo)
                        {
                            valorMinimo = numero;
                        }
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado está fuera del rango permitido (-100 a 100). Inténtalo de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtalo de nuevo.");
                }

            }
            double promedio = (double)suma / 10;

            Console.WriteLine($"Valor mínimo ingresado: {valorMinimo}");
            Console.WriteLine($"Valor máximo ingresado: {valorMaximo}");
            Console.WriteLine($"Promedio de los números ingresados: {promedio}");


        }


    }
}


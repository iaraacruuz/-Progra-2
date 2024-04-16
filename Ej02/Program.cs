namespace Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int suma = 0;
            bool continuar = true;

            while(continuar)
            {
                Console.WriteLine("Ingrese un numero:");
                string ingreso = Console.ReadLine();
                if (int.TryParse(ingreso, out int numero))
                {
                    suma += numero;
                    Console.WriteLine("Desea Continuar? S/N");
                    string respuesta = Console.ReadLine();
                    continuar= Validador.ValidarRespuesta(respuesta);

                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }

            }
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
        }
    }
}

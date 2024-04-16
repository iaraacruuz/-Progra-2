namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese por favor un numero del 1 al 10");
            string numero = Console.ReadLine();

            int numeroIngreso;
            if (int.TryParse(numero, out numeroIngreso))
            {
                string tabla = StringBuilder.tablaMultiplicacion(numeroIngreso);
                Console.WriteLine(tabla);
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido.");
            }



        }
    }
}

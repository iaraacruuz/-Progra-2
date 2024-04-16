namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresadaString;
            DateTime fechaIngresada;
            int diasPasados;

            //al menos una vez se ejecuta el do while, si se cumple la condicion se ejecuta mad veces
            //ideal para usarlo cuando al menos quieor q me bucle se ejecute una vez, el qhile lo uso cuando no se cunaats vece sse va a ejecutar. y el for cuanod yo se cuanats veecs se va a ejecutar ese bucle.

            do
            {
                Console.WriteLine("Ingrese una fecha (dd/mm/aaaa)");
                fechaIngresadaString = Console.ReadLine();
                if (DateTime.TryParse(fechaIngresadaString, out fechaIngresada))
                {
                    diasPasados = Calculadora.CalcularDias(fechaIngresada);
                    Console.WriteLine($" desde la fecha ingresada pasaron:{diasPasados}");

                }
                else
                {
                    Console.WriteLine("Error por favor ingrese una fecha valida");
                    Console.WriteLine("Formate: dd/mm/aaaa (dia, mes, año)");
                }



            } while (fechaIngresada.Year == 0001);
        }
    }
}

namespace Ej03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            if (numeroEntero==0)
            {
                return "0";
            }
            string binario = "";
            while(numeroEntero>0)
            {
                int residuo;
                residuo = numeroEntero % 2;
                binario = residuo.ToString() + binario;
                numeroEntero = numeroEntero / 2;

            }
            return binario;
        }
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int
        }
    }
}

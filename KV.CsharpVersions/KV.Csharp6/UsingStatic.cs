using static System.Console;
using static System.Math;

namespace KV.Csharp6
{    
    public static class UsingStatic
    {        
        public static void Example()
        {
            int numero = 4;

            WriteLine("Número: " + numero);
            WriteLine("Raiz quadrada = " + Sqrt(numero));
            WriteLine("4 ^ 5 = " + Pow(numero, 5));
            WriteLine("4 ^ 10 = " + Pow(numero, 10));

            ReadKey();
        }
    }
}

using System;

namespace KV.Csharp6
{
    public static class NameOf
    {
        public static void Example()
        {
            DateTime dataExemplo1 = new DateTime(2014, 11, 01);
            DateTime dataExemplo2 = new DateTime(2014, 12, 01);

            Console.WriteLine("Variável 1: " + nameof(dataExemplo1));
            Console.WriteLine("Variável 2: " + nameof(dataExemplo2));

            Console.ReadKey();
        }
    }
}

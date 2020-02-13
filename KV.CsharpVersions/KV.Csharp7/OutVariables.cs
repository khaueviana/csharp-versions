using System;

namespace KV.Csharp7
{
    static class OutVariables
    {
        public static void Execute()
        {
            // specify type
            if(int.TryParse("123", out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could Not Parse");
            }

            // not specify type
            if (int.TryParse("123", out var result2))
            {
                Console.WriteLine(result2);
            }
            else
            {
                Console.WriteLine("Could Not Parse");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KV.Csharp7
{
    static class GeneralizedAsyncReturnTypes
    {
        public static async ValueTask<int> Execute()
        {
            var x = await Func();
            Console.WriteLine(x);
            return x;
        }

        private static async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }
    }
}

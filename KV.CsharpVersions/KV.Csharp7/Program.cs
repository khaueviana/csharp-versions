using System.Threading.Tasks;

namespace KV.Csharp7
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            OutVariables.Execute();
            Tuples.Execute();
            Discards.Execute();
            PatternMatching.Execute();
            RefsLocalsReturns.Execute();
            await GeneralizedAsyncReturnTypes.Execute();
        }
    }
}

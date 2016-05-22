namespace KV.Csharp6.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceUsingStatic.Example();

            ResourceNameOf.Example();

            ResourceAutoPropertyInitializer.Example();

            ResourceExpressionBodiedMember.Example();

            ResourceDictionaryInitializer.Example();

            ResourceExceptionFilter.Example();

            ResourcePropertyConstructorInitializer.Example();

            ResourceStringInterpolation.Example();

            ResourceAsyncCathFinally.Example();

            ResourceNullConditional.Example();

            ResourceDelegateNull.Example();
        }
    }
}

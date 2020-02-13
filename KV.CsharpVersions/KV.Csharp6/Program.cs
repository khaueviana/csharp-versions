namespace KV.Csharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingStatic.Execute();

            NameOf.Execute();

            AutoPropertyInitializer.Execute();

            ExpressionBodiedMember.Execute();

            DictionaryInitializer.Execute();

            ExceptionFilter.Execute();

            PropertyConstructorInitializer.Execute();

            StringInterpolation.Execute();

            AsyncCathFinally.Execute();

            NullConditional.Execute();

            DelegateNull.Execute();
        }
    }
}

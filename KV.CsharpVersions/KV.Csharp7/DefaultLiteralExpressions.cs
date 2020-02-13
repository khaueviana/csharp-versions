using System;

namespace KV.Csharp7
{
    public static class DefaultLiteralExpressions
    {
        public static void Execute()
        {
            // :(
            Func<string, bool> whereClause1 = default(Func<string, bool>);

            // :)
            Func<string, bool> whereClause2 = default;
        }
    }
}

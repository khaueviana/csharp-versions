namespace KV.Csharp7
{
    public static class CondtionalRefExpressions
    {
        private static object[] arr;
        private static object[] otherArr;

        public static void Execute()
        {
            ref object r = ref (arr != null
                ? ref arr[0]
                : ref otherArr[0]);
        }
    }
}

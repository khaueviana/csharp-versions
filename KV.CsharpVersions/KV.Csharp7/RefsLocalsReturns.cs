using System;

namespace KV.Csharp7
{
    public static class RefsLocalsReturns
    {
        public static void Execute()
        {
            int[,] matrix = new int[4, 2];
            matrix[0, 0] = 33;
            matrix[3, 1] = 42;

            ref var item = ref Find(matrix, (val) => val == 42);
            Console.WriteLine(item);
            item = 24;
            Console.WriteLine(matrix[3, 1]);
        }

        public static ref int Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }
    }
}

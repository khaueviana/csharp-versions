using System;

namespace KV.Csharp7
{
    static class Tuples
    {
        public static void Execute()
        {
            // unnamed parameters
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");
            
            // named parameters
            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            // using tuples in methods
            (int max, int min) = Xablau((1, 2));

            // using descontrcut in a class type
            (double x, double y) = new Point(10, 20);
        }

        private static (int max, int min) Xablau((int max, int min) numbers)
        {
            return numbers;
        }
    }

    public class Point
    {
        public Point(double x, double y) => (X, Y) = (x , y);

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y) =>
            (x, y) = (X, Y);
    }
}
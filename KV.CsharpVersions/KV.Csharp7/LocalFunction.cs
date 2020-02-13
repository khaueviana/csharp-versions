using System;
using System.Collections.Generic;

namespace KV.Csharp7
{
    public static class LocalFunction
    {
        public static IEnumerable<char> Execute(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace KV.Csharp7
{
    public static class PatternMatching
    {
        public static void Execute()
        {
            List<object> value = new List<object>();
            value.Add(200);
            value.Add(300);

            value.Add(new List<int>{ 1 });

            SumPositiveNumbers(value);
        }

        public static int SumPositiveNumbers(IEnumerable<object> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case IEnumerable<int> childSequence:
                        {
                            foreach (var item in childSequence)
                                sum += (item > 0) ? item : 0;
                            break;
                        }
                    case int n when n > 0:
                        sum += n;
                        break;
                    case null:
                        throw new NullReferenceException("Null found in sequence");
                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }
            return sum;
        }
    }
}

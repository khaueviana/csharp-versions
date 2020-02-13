using System;

namespace KV.Csharp7
{
    public static class NumericReadability
    {
        public static void Execute()
        {
            long BillionsAndBillions = 100_000_000_000;
            double AvogadroConstant = 6.022_140_857_747_474e23;
            decimal GoldenRatio = 1.618_033_988_749_894_848_204_586_834_365_638_117_720_309_179M;

            Console.WriteLine(BillionsAndBillions);
            Console.WriteLine(AvogadroConstant);
            Console.WriteLine(GoldenRatio);
        }
    }
}
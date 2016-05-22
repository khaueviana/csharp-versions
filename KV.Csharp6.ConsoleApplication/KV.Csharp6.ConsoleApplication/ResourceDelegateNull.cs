using System;
using System.Threading;
using static KV.Csharp6.ConsoleApplication.CurrencyQuote;

namespace KV.Csharp6.ConsoleApplication
{
    public static class ResourceDelegateNull
    {
        public static void Example()
        {
            CurrencyQuote quote = new CurrencyQuote("Dólar norte-americano", "US$");
            quote.QuoteUpdate += processoQuoteUpdate;
            quote.QuoteValue = 2.858;

            Thread.Sleep(3000);
            quote.QuoteValue = 2.866;

            Console.ReadKey();
        }

        private static void processoQuoteUpdate(object sender, QuoteUpdateEventArgs e)
        {
            Console.WriteLine(
                $"Moeda: {e.Symbol} - " +
                $"Data/Hora da Cotação: {e.LastUpdate:HH:mm:ss} - " +
                $"Valor da Cotação: {e.QuoteValue:0.000}");
        }
    }

    public class CurrencyQuote
    {
        public string Currency { get; }
        public string Symbol { get; }
        public DateTime QuoteDate { get; }

        private DateTime lastUpdate;

        public DateTime LastUpdate
        {
            get { return lastUpdate; }
        }

        private double? quoteValue;

        public double QuoteValue
        {
            get { return quoteValue ?? 0; }

            set
            {
                quoteValue = value;
                lastUpdate = DateTime.Now;

                QuoteUpdate?.Invoke(this, new QuoteUpdateEventArgs(
                        Symbol,
                        lastUpdate,
                        value));
            }
        }

        public event QuoteUpdateHandler QuoteUpdate;

        public CurrencyQuote(string currency, string symbol)
        {
            Currency = currency;
            Symbol = symbol;
            QuoteDate = DateTime.Now.Date;
        }

        public class QuoteUpdateEventArgs : EventArgs
        {
            public string Symbol { get; }
            public DateTime LastUpdate { get; }
            public double QuoteValue { get; }

            public QuoteUpdateEventArgs(string symbol, DateTime lastUpdate, double quoteValue)
            {
                Symbol = symbol;
                LastUpdate = lastUpdate;
                QuoteValue = quoteValue;
            }
        }

        public delegate void QuoteUpdateHandler(object sender, QuoteUpdateEventArgs e);
    }
}

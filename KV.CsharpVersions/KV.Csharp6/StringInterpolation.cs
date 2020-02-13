using System;
using System.Globalization;

namespace KV.Csharp6
{
    public static class StringInterpolation
    {
        public static void Execute()
        {
            DateTime currentDate = DateTime.Now;
            CultureInfo localConfiguration = new CultureInfo("pt-BR");

            string mensagem = $"São Paulo, {localConfiguration.DateTimeFormat.GetDayName(currentDate.DayOfWeek)}, {currentDate.Day} " +
                              $"de {localConfiguration.DateTimeFormat.GetMonthName(currentDate.Month)} de {currentDate.Year} - {currentDate:HH:MM:ss}";
        }
    }
}

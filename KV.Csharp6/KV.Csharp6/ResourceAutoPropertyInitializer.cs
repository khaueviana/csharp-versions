using System;

namespace KV.Csharp6
{
    public static class ResourceAutoPropertyInitializer
    {
        public static void Example()
        {
            LogMessage logMessage = new LogMessage();

            Console.WriteLine("Valores do objeto MensagemLog logo após a inicialização...\n");
            Console.WriteLine(ShowLogContent(logMessage));

            logMessage.Type = LogType.Alert;
            logMessage.Message = "Exemplo de mensagem de alerta.";

            Console.WriteLine("\n\nValores do objeto MensagemLog logo após alterações...\n");
            Console.WriteLine(ShowLogContent(logMessage));

            Console.ReadKey();
        }

        public static string ShowLogContent(LogMessage log)
        {
            return String.Format(
                "*** Mensagem de Log ***\nData: {0}\nTipo: {1}\nMensagem: {2}",
                log.Date, log.Type, log.Message);
        }
    }

    public enum LogType
    {
        Information,
        Alert,
        Error
    }

    public class LogMessage
    {
        public DateTime Date { get; } = DateTime.Now;
        public LogType Type { get; set; } = LogType.Information;
        public string Message { get; set; }
    }
}

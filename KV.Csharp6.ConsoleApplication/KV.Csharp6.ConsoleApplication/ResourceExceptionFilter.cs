using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KV.Csharp6.ConsoleApplication
{
    public static class ResourceExceptionFilter
    {
        public static void Example()
        {
            Console.WriteLine("Testando a geração de exceções...");

            try
            {
                throw new ExceptionTeste("Gerando um erro para demonstração...");
            }
            //catch (ExceptionTeste ex) if (ex.SeveriyLevel == 1) -- Versões anteriores
            catch (ExceptionTeste ex) when (ex.SeveriyLevel == 1)
            {
                Console.WriteLine("Aconteceu um erro com um nível de severidade baixo...");
            }
            //catch (ExceptionTeste ex) if (ex.SeveriyLevel <= 3) -- Versões anteriores
            catch (ExceptionTeste ex) when (ex.SeveriyLevel <= 3)
            {
                Console.WriteLine("Aconteceu um erro com um nível de severidade moderado...");
            }
            catch (ExceptionTeste)
            {
                Console.WriteLine("Aconteceu um erro com um nível de severidade alto...");
            }

            Console.ReadKey();
        }
    }

    public class ExceptionTeste : Exception
    {
        private int severityLevel;

        public int SeveriyLevel
        {
            get
            {
                return severityLevel;
            }
        }

        public ExceptionTeste(string mensagem)
            : base(mensagem)
        {
            Random r = new Random();
            severityLevel = r.Next(1, 5);
        }
    }
}

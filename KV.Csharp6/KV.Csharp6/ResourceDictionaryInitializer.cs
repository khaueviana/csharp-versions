using System.Collections.Generic;

namespace KV.Csharp6
{
    public static class ResourceDictionaryInitializer
    {
        public static void Example()
        {
            Dictionary<string, string> capitais = new Dictionary<string, string>()
            {
                ["SP"] = "São Paulo",
                ["RJ"] = "Rio de Janeiro",
                ["MG"] = "Minas Gerais",
                ["RS"] = "Porto Alegre",
                ["BA"] = "Salvador",
                ["SC"] = "Santa Catarina",
                ["DF"] = "Brasília"
            };
        }
    }
}

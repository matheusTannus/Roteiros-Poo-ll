using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"{
            'Servidor': 'localhost',
            'Porta': 3306,
            'Usuario': 'admin'
        }";

        JObject config = JObject.Parse(json);

        config["Porta"] = 5432;

        Console.WriteLine(config.ToString());
    }
}

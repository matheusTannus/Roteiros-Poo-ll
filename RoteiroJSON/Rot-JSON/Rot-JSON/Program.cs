using Newtonsoft.Json;
using System;
using System.Text.Json;
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}


class Program
{
    static void Main()
    {
        Livro livro = new Livro
        {
            Titulo = "O cabuloso",
            Autor = "Matheus Tannus",
            Ano = 2025
        };
        
        string json = JsonConvert.SerializeObject(livro,Formatting.Indented);

        Console.WriteLine(json);
    }
}

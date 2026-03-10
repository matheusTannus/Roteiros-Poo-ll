using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("aluno.json");

        Aluno aluno = JsonSerializer.Deserialize<Aluno>(json);

        Console.WriteLine("Nome: " + aluno.Nome);
        Console.WriteLine("Idade: " + aluno.Idade);
        Console.WriteLine("Curso: " + aluno.Curso);
    }
}
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

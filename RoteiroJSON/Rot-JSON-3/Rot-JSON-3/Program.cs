using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}


class Program
{
    static void Main()
    {
        List<Carro> carros = new List<Carro>
        {
            new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020 },
            new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2019 },
            new Carro { Marca = "Ford", Modelo = "Focus", Ano = 2018 }
        };

        string json = JsonSerializer.Serialize(carros, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("carros.json", json);

        string jsonLido = File.ReadAllText("carros.json");

        List<Carro> carrosLidos = JsonSerializer.Deserialize<List<Carro>>(jsonLido);

        // Exibir no console
        foreach (var carro in carrosLidos)
        {
            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine("---------------------");
        }
    }
}

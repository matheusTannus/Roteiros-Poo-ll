using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Produto
{
    [JsonProperty(Order = 1)]
    public int Id { get; set; }

   
    [JsonProperty("product_name", Order = 2, Required = Required.Always)]
    public string Nome { get; set; }


    [JsonProperty("product_price", Order = 3, Required = Required.Always)]
    public double Preco { get; set; }

    [JsonProperty(Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(Order = 5)]
    public string Fornecedor { get; set; }


    [JsonIgnore]
    public string CodigoInterno { get; set; }
}

class Program
{
    static void Main()
    {
        
        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500,
                Estoque = 10,
                Fornecedor = "Dell",
                CodigoInterno = "NB001"
            },
            new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 80,
                Estoque = 50,
                Fornecedor = null, 
                CodigoInterno = "MS002"
            },
            new Produto
            {
                Id = 3,
                Nome = null,
                Preco = 150,
                Estoque = 30,
                Fornecedor = "Logitech",
                CodigoInterno = "TC003"
            }
        };

       
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore 
        };

        string json = JsonConvert.SerializeObject(produtos, settings);
        File.WriteAllText("produtos.json", json);

        Console.WriteLine("Arquivo produtos.json criado com sucesso!\n");

        try
        {
            string jsonLido = File.ReadAllText("produtos.json");
            List<Produto> produtosLidos = JsonConvert.DeserializeObject<List<Produto>>(jsonLido);

            Console.WriteLine("Produtos lidos do JSON:\n");
            foreach (var p in produtosLidos)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Nome: {p.Nome}");
                Console.WriteLine($"Preço: {p.Preco}");
                Console.WriteLine($"Estoque: {p.Estoque}");
                Console.WriteLine($"Fornecedor: {p.Fornecedor}");
                Console.WriteLine("------------------------");
            }
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("Erro na desserialização (campo obrigatório faltando):");
            Console.WriteLine(ex.Message);
        }

      
        string jsonInvalido = @"[
            { 'Id': 4, 'Estoque': 15, 'Fornecedor': 'Samsung' }
        ]";

        try
        {
            List<Produto> produtosInvalidos = JsonConvert.DeserializeObject<List<Produto>>(jsonInvalido);
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("\nTeste com JSON inválido (faltando Nome ou Preço):");
            Console.WriteLine(ex.Message);
        }
    }
}
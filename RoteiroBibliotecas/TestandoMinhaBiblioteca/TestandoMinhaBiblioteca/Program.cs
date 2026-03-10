using System;
using BibliotecaConversao;
using BibliotecaValidacoes;
using BibliotecaMultiplicacao;
using AreaTrianguloIgor;
using BibliotecaFinanceira;

namespace TestandoMinhaBiblioteca
{
    class Program
    {
        static void Main()
        {
            /*Console.Title = "Sistema de Teste das DLLs";

            Console.WriteLine("=================================");
            Console.WriteLine("   SISTEMA DE TESTE DE DLLs");          //atividade 2
            Console.WriteLine("=================================\n");

            //atividade 1

            // ---------------- CONVERSÕES ----------------
            Console.WriteLine("=== CONVERSÕES ===");

            var conversao = new Conversao();

            Console.Write("Digite graus Celsius ex: (35,8) : ");
            float graus = float.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + conversao.Graus(graus));

            Console.Write("\nDigite metros: ");
            float metros = float.Parse(Console.ReadLine());
            Console.WriteLine(  conversao.Metros(metros) +" KM ");

            Console.Write("\nInsira o valor para conversão de moeda: ");    //atividade 3
            float valor = float.Parse(Console.ReadLine());

            Console.Write("Insira a taxa de câmbio ex: (0,05 para 5%) : ");
            float taxa = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor convertido: " + conversao.Moeda(valor, taxa));

            //atividade 4

            // ---------------- MULTIPLICAÇÃO ----------------
            Console.WriteLine("\n=== MULTIPLICAÇÃO ===");

            Calculo Calc = new Calculo();

            Console.Write("Digite o primeiro número : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número : ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = Calc.Multiplicar(n1, n2);

            Console.WriteLine("Resultado da multiplicação: " + resultado);

            
            
            //atividade 5

            // ---------------- ÁREA DO TRIÂNGULO ----------------
            Console.WriteLine("\n=== ÁREA DO TRIÂNGULO ===");

            var CalculoArea = new Area();

            Console.Write("Digite a base do triângulo: ");
            double baseTri = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = CalculoArea.CalculoDaArea(baseTri, altura);

            Console.WriteLine("A área do triângulo é: " + area);
            
            
            //atividade 6
            // ---------------- JUROS SIMPLES ----------------  
            Console.WriteLine("\n=== JUROS SIMPLES ===");
                                                
            CalculadoraJuros calc = new CalculadoraJuros();

            Console.Write("Digite o capital inicial: ");
            double capital = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa (ex: 0,05 para 5%): ");
            double taxaJuros = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo em (anos): ");
            double tempo = double.Parse(Console.ReadLine());

            double juros = calc.JurosSimples(capital, taxaJuros, tempo);

            Console.WriteLine("Juros simples calculado: " + juros);
            Console.WriteLine("Valor total acumulado: " + (capital + juros));

            //atividade 7

            // ---------------- VALIDAÇÕES ----------------
            Console.WriteLine("\n=== SISTEMA DE VALIDAÇÃO ===");

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine() ?? "";

            if (Validacoes.ValidarCpf(cpf))
                Console.WriteLine("CPF válido");
            else
                Console.WriteLine("CPF inválido");

            Console.Write("\nDigite o Email: ");
            string email = Console.ReadLine() ?? "";

            if (Validacoes.ValidarEmail(email))
                Console.WriteLine("Email válido");
            else
                Console.WriteLine("Email inválido");

            Console.Write("\nDigite a Senha: ");
            string senha = Console.ReadLine() ?? "";

            if (Validacoes.ValidarSenha(senha))
                Console.WriteLine("Senha válida");
            else
                Console.WriteLine("Senha inválida");

            Console.WriteLine("\n=================================");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();*/
        }
    }
}
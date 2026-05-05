using System;
using ExceptionRoteiro;
using ExceptionRoteiro.Exceptionsmet;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao sistema bancário!");
        Console.Write("Insira sua idade: ");

        string entrada_idade = Console.ReadLine() ?? "";

        try
        {
            int idade = int.Parse(entrada_idade);

            if (idade < 18)
            {
                throw new IdadeInvalidaException();
            }

            Console.WriteLine("Idade válida: " + idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            return;
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: digite apenas números!");
            return;
        }

        Conta conta2 = new Conta(10, "Matheus", 100m);
        Conta conta = new Conta(100, "Maria", 100m);

        try
        {          
            Console.WriteLine(conta);

            conta.Depositar(7000);
            Console.WriteLine($"Saldo ct1: {conta.Saldo}");

            decimal valorsaque1 = 5001;

            conta.Sacar(valorsaque1);
            Console.WriteLine($"Saldo ct1 depois do saque: {conta.Saldo}");

            conta.Transferir(conta2, 1000);
            Console.WriteLine($"Saldo ct1 depois da transferência: {conta.Saldo}");
            Console.WriteLine("Valor transferido com sucesso!");
            
            Console.WriteLine($"Saldo da conta destino: {conta2.Saldo}");
        }
        catch (LimiteDiarioException ex)
        {
            Console.WriteLine("ERRO: LIMITE POR SAQUE EXCEDIDO");
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ajuda: " + ex.HelpLink);
        }
        catch (LimiteDiarioAcumuladoException ex)
        {
            Console.WriteLine("ERRO: LIMITE DIÁRIO EXCEDIDO");
            Console.WriteLine(ex.Message);
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine("ERRO: SALDO INSUFICIENTE");
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("Causa interna: " + ex.InnerException.Message);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro de validação: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
    }
}
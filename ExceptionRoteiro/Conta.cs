using System;
using ExceptionRoteiro.Exceptionsmet;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ExceptionRoteiro
{
    public class Conta
    {
        public Conta(int numero, string titular, decimal saldo)
        {
            if (string.IsNullOrWhiteSpace(titular))
                throw new ArgumentException("Titular não pode ser vazio");

            if (saldo < 0)
                throw new ArgumentException("Saldo inicial não pode ser negativo");

            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        
        private decimal totalSacadoHoje = 0;
        private decimal limiteSaqueAcumulado = 10000;

        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public decimal Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do depósito deve ser positivo");

            if (valor >= 10000)
                throw new ArgumentException("Valor de depósito tem que ser menor que 10.000,00");

            Saldo += valor;
            return Saldo;
        }

        public decimal Sacar(decimal valor)
        {
            try
            {
                if (valor <= 0)
                    throw new ArgumentException("Valor do saque deve ser positivo");

                
                if (valor > 5000)
                    throw new LimiteDiarioException();

               
                if (totalSacadoHoje + valor > limiteSaqueAcumulado)
                    throw new LimiteDiarioAcumuladoException(valor, totalSacadoHoje);

                
                if (Saldo < valor)
                    throw new SaldoInsuficienteException();

                Saldo -= valor;
                totalSacadoHoje += valor;

                return Saldo;
            }
            catch (LimiteDiarioException)
            {
                throw; 
            }
            catch (LimiteDiarioAcumuladoException)
            {
                throw; 
            }
            catch (SaldoInsuficienteException)
            {
                throw; 
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao realizar saque", ex);
            }
        }

        public void Transferir(Conta destino, decimal valor)
        {
            if (destino == null)
                throw new ArgumentNullException(nameof(destino));

            if (valor <= 0)
                throw new ArgumentException("Valor deve ser positivo", nameof(valor));

            Sacar(valor);
            destino.Depositar(valor);
        }

        public override string ToString()
        {
            return $"Conta: {Numero} - {Titular} - Saldo: {Saldo}";
        }
    }
}
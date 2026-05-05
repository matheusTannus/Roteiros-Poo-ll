using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionRoteiro.Exceptionsmet
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public decimal ValorSaque { get; }
        public decimal SaldoAtual { get; }
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message)
        : base(message) { }
        public SaldoInsuficienteException(string message, Exception inner)
        : base(message, inner) { }
        public SaldoInsuficienteException(decimal saque, decimal saldo, Exception
       inner)
        : base($"Saque de {saque} não permitido. Saldo atual: {saldo}", inner)
        {
            ValorSaque = saque;
            SaldoAtual = saldo;
        }
        public override string HelpLink
        {
            get => "https://meusistema.com/erros/saldo-insuficiente";
        }
    }
}

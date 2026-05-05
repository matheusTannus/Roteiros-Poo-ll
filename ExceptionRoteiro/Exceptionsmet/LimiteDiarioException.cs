using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionRoteiro.Exceptionsmet
{
    public class LimiteDiarioException : Exception
    {
        public decimal ValorSaque { get; }
        public LimiteDiarioException()
        : base($"Saque não permitido, pois limite é de 5.000,00 por saque")
        {

        }
        public LimiteDiarioException(decimal valor, decimal totalSacado)
        : base($"Limite diário excedido. Tentativa: {valor:C}, já sacado hoje: {totalSacado:C}")
        {
            ValorSaque = valor;
        }

        public override string HelpLink
        {
            get => "https://meusistema.com/erros/saque-acima-do-permitido";
        }
    }
}

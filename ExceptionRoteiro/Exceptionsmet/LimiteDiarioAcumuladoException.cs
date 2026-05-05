using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionRoteiro.Exceptionsmet
{
    public class LimiteDiarioAcumuladoException : Exception
    {
        public decimal ValorTentativa { get; }
        public decimal TotalSacadoHoje { get; }

        public LimiteDiarioAcumuladoException(decimal valor, decimal total)
            : base($"Limite diário acumulado excedido. Tentativa: {valor:C}. Já sacado hoje: {total:C}.")
        {
            ValorTentativa = valor;
            TotalSacadoHoje = total;
        }
    }
}
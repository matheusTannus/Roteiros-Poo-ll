using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionRoteiro.Exceptionsmet
{
    public class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException()
            : base("Que pena, apenas maiores de 18 anos podem abrir conta!")
        {
        }
    }
}

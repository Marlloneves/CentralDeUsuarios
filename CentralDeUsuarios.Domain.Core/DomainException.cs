using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Domain.Core
{
    /// <summary>
    /// Classe para retorno de exceções do domínio
    /// </summary>
    public class DomainException : Exception
    {
        public DomainException(string errorMessage)
            :base(errorMessage)
        {

        }
        /// <summary>
        /// Método para teste um condição de erro e disparar um exceção
        /// </summary>
        /// <param name="hasError">Condição para disparar o erro</param>
        /// <param name="errorMessage">Mensagem de erro</param>
        /// <exception cref="DomainException"></exception>
        public static void When(bool hasError, string errorMessage)
        {
            if (hasError)
            {
                throw new DomainException(errorMessage);
            }
        }
    }
}

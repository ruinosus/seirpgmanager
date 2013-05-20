using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeiRPGManager.Entidades.Exceptions
{
    public class SeiRPGManagerExceptionValidacao : Exception
    {
        public SeiRPGManagerExceptionValidacao(string message) :
            base(message)
        {

        }

        /// <summary>
        /// Construtor .
        /// </summary>
        protected SeiRPGManagerExceptionValidacao()
            : base(string.Empty)
        {
            this.Mensagens = new List<string>();
        }

        /// <summary>
        /// Construtor da Exceção
        /// </summary>
        /// <param name="message">Mensagem da exceção</param>
        /// <param name="innerException">Exceção interna</param>
        public SeiRPGManagerExceptionValidacao(string message, Exception innerException)
            : base(message, innerException)
        {
            this.Mensagens = new List<string>();
        }

        /// <summary>
        /// Construtor da Exceção
        /// </summary>
        /// <param name="mensagens">Mensagens de exceções de negócio.</param>
        public SeiRPGManagerExceptionValidacao(IList<string> mensagens)
            : this()
        {
            this.Mensagens = mensagens;
        }

        /// <summary>
        /// Obtém a lista de mensagens de exceções de negócio.
        /// </summary>
        /// <param name="token">Token da mensagem a ser levantada</param>
        /// <param name="valoresParametros">Valores para compor a mensagem a ser levantada</param>
        public SeiRPGManagerExceptionValidacao(string token, params object[] valoresParametros)
            : base(String.Format(token, valoresParametros))
        {
            this.Mensagens = new List<string>();
        }

        /// <summary>
        /// Obtém a lista de mensagens de exceções de negócio.
        /// </summary>
        public IList<string> Mensagens { get; private set; }
    }
}


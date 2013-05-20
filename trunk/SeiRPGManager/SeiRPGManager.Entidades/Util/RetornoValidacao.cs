
namespace SeiRPGManager.Entidades.Util
{
    using SeiRPGManager.Entidades.Exceptions;
    using System.Collections.Generic;

    /// <summary>
    /// Classe que representa a entidade retorno da validação.
    /// </summary>
    public class RetornoValidacao
    {
        /// <summary>
        /// Parametro que indica as mensagens do retorno da validação.
        /// </summary>
        private IList<string> mensagens;

        /// <summary>
        /// Parametro que indica se o retorno da validação é válido.
        /// </summary>
        private bool valido;

        /// <summary>
        /// Construtor .
        /// </summary>
        /// <param name="tipoRetornoValidacao">Tipo do retorno da validação.</param>
        public RetornoValidacao(TipoRetornoValidacao tipoRetornoValidacao)
        {
            this.TipoRetornoValidacao = tipoRetornoValidacao;

            if (tipoRetornoValidacao != TipoRetornoValidacao.Nenhum)
            {
                this.mensagens = new List<string>();
            }

            this.valido = true;
        }

        /// <summary>
        /// Obtém se o retorno da validação é válido.
        /// </summary>
        public bool ValidacaoOk
        {
            get { return this.valido; }
        }

        /// <summary>
        /// Obtém as mensagens do retorno da validação.
        /// </summary>
        public IList<string> Mensagens
        {
            get { return this.mensagens; }
        }

        /// <summary>
        /// Obtém / Define otipo de retorno da validação.
        /// </summary>
        public TipoRetornoValidacao TipoRetornoValidacao { get; set; }


        /// <summary>
        /// Adiciona uma mensagem a lista de mensagens de exceção das validações mal sucedidas.
        /// </summary>
        /// <param name="mensagem">Conteúdo da mensagem.</param>
        public void AddMensagem(string mensagem)
        {
            if (this.mensagens != null)
            {
                this.mensagens.Add(mensagem);
            }

            this.valido = false;
        }

        /// <summary>
        /// Adiciona as mensagens contidas na lista de mensagens do retorno de validação informado.
        /// </summary>
        /// <param name="retornoValidacao">Retorna da validação cujas mensagens serão copiadas.</param>
        public void AddMensagem(RetornoValidacao retornoValidacao)
        {
            if (retornoValidacao != null)
            {
                if ((this.mensagens != null) && (retornoValidacao.mensagens != null) && (this.mensagens != retornoValidacao.mensagens))
                {
                    foreach (string s in retornoValidacao.mensagens)
                    {
                        this.mensagens.Add(s);
                    }
                }

                this.valido = false;
            }
        }

        /// <summary>
        /// Levanta a uma <see cref="NegocioException"/> caso existam mensagens de exceção e o tipo do retorno da validação seja 
        /// <see cref="TipoRetornoValidacao.LevantarExcecao"/>.
        /// </summary>
        public void LevantarExcecao()
        {
            this.LevantarExcecao(this.TipoRetornoValidacao);
        }

        /// <summary>
        /// Levanta a uma <see cref="NegocioException"/> caso existam mensagens de exceção e o tipo do retorno da validação seja 
        /// <see cref="TipoRetornoValidacao.LevantarExcecao"/>.
        /// </summary>
        /// <param name="tipo">Tipo do retorno da validação.</param>
        public void LevantarExcecao(TipoRetornoValidacao tipo)
        {
            if ((tipo == TipoRetornoValidacao.LevantarExcecao) && (this.mensagens != null) && (this.mensagens.Count > 0))
            {
                throw new SeiRPGManagerExceptionValidacao(this.mensagens);
            }
        }
    }
}

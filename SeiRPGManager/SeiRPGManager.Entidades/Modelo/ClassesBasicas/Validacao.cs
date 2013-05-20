using SeiRPGManager.Entidades.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    public class Validacao
    {
        #region ValidaCaracterInvalido
        /// <summary>
        /// Valida Caracteres inválidos
        /// </summary>
        /// <param name="stringEntrada">Valida a  String de Entrada verificando se possui caracteres especiais</param>
        /// <returns>Retorna Booleano</returns>
        private static bool ValidaCaracterInvalido(string stringEntrada)
        {
            bool retorno = true;
            if (!string.IsNullOrWhiteSpace(stringEntrada))
            {
                string strEnt = stringEntrada.Replace(" ", string.Empty);

                string stringCaracteresInvalidos = "!.@.#.$.%.&.*.(.)._.-.+.=";

                char[] c = ".".ToCharArray(0, 1);

                string[] str = stringCaracteresInvalidos.Split(c);

                foreach (string caracter in str)
                {
                    if (strEnt.ToUpper(CultureInfo.CurrentCulture).IndexOf(@caracter, StringComparison.CurrentCulture) > 0)
                    {
                        retorno = false;
                    }
                }
            }

            return retorno;
        }

        #endregion

        #region ValidarLimitesString

        /// <summary>
        /// Valida os limites de uma string.
        /// </summary>
        /// <param name="valor">valor da string</param>
        /// <param name="limiteMin">limite mínimo da string</param>
        /// <param name="limiteMax">limite máximo da string</param>
        /// <param name="tokenNomeCampo">token do nome para mensagem</param>
        /// <param name="retornoValidacao">retorno da validação</param>
        private static void ValidarLimitesString(string valor, int limiteMin, int limiteMax, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            if ((string.IsNullOrWhiteSpace(valor) && (limiteMin > 0)) || (!string.IsNullOrWhiteSpace(valor) && ((valor.Length < limiteMin) || (valor.Length > limiteMax))))
            {
                retornoValidacao.AddMensagem(String.Format(
                    "MENSAGEM VALIDACAO .MsgCampoIntervaloTexto", String.Format(tokenNomeCampo), limiteMin, limiteMax));
            }
        }

        #endregion

        #region ValidarPropriedadeReferencia

        /// <summary>
        /// Valida as propriedades de uma referência.
        /// </summary>
        /// <param name="propriedade">objeto da propriedade</param>
        /// <param name="requerido">true se requerido</param>
        /// <param name="tokenNomePropriedade">token do nome para mensagem</param>
        /// <param name="retornoValidacao">retorno da validação</param>
        /// <param name="validacao">ação para validação</param>
        private static void ValidarPropriedadeReferencia(
            object propriedade,
            bool requerido,
            string tokenNomePropriedade,
            RetornoValidacao retornoValidacao,
            Func<RetornoValidacao> validacao)
        {
            if (requerido && propriedade == null)
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgCampoObrigatorio", tokenNomePropriedade));
            }

            if (propriedade != null)
            {
                retornoValidacao.AddMensagem(validacao());
            }
        }

        #endregion

        #region ValidarPropriedadeNula

        /// <summary>
        /// Valida uma propriedade se ela é nula.
        /// </summary>
        /// <param name="propriedade">objeto da propriedade</param>
        /// <param name="tokenNomePropriedade">token do nome para mensagem</param>
        /// <param name="retornoValidacao">retorno da validação</param>
        private static void ValidarPropriedadeNula(
            object propriedade, string tokenNomePropriedade, RetornoValidacao retornoValidacao)
        {
            if (propriedade == null)
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgCampoObrigatorio", tokenNomePropriedade));
            }
        }

        #endregion

        #region ValidarLimitesInteiro

        /// <summary>
        /// Valida o Limites de uma variavel inteira.
        /// </summary>
        /// <param name="valor">Valor do inteiro</param>
        /// <param name="limiteMin">Limite mínimo do inteiro</param>
        /// <param name="limiteMax">Limite maximo do inteiro</param>
        /// <param name="tokenNomeCampo">Token do nome para mensagem</param>
        /// <param name="retornoValidacao">Rotorno da validação</param>
        private static void ValidarLimitesInteiro(int valor, int limiteMin, int limiteMax, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            string valorAux = Convert.ToString(valor, CultureInfo.CurrentCulture);
            if ((valorAux.Length < limiteMin) || (valorAux.Length > limiteMax))
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgCampoIntervaloTexto", tokenNomeCampo, limiteMin, limiteMax));
            }
        }

        #endregion

        #region ValidarLimitesDecimal

        /// <summary>
        /// Valida o Limites de uma variavel Decimal.
        /// </summary>
        /// <param name="valor">Valor do Decimal</param>
        /// <param name="limiteMin">Limite mínimo do Decimal</param>
        /// <param name="limiteMax">Limite maximo do Decimal</param>
        /// <param name="tokenNomeCampo">Token do nome para mensagem</param>
        /// <param name="retornoValidacao">Rotorno da validação</param>
        private static void ValidarLimitesDecimal(double valor, float limiteMin, float limiteMax, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            if ((valor < limiteMin) || (valor > limiteMax))
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgCampoIntervalo", tokenNomeCampo, limiteMin, limiteMax));
            }
        }

        #endregion

        #region ValidarValorMenorOuIgual

        /// <summary>
        /// Valida a quantidade máxima de caracteres no campo.
        /// </summary>
        /// <param name="valor">valor da string</param>
        /// <param name="limite">Limite do campo</param>
        /// <param name="requerido">true se requerido</param>
        /// <param name="tokenNomeCampo">Token do nome do campo para Mensagem</param>
        /// <param name="retornoValidacao">Rotorno da Validação</param>
        private static void ValidarValorMenorOuIgual(string valor, int limite, bool requerido, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            if (requerido && valor.Length > limite)
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgMenorOuIgual", tokenNomeCampo, limite));
            }
            if (valor != null && requerido == false && valor.Length > limite)
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgMenorOuIgual", tokenNomeCampo, limite));
            }
        }

        #endregion

        #region ValidarValorIgual

        /// <summary>
        /// Valida se a quantida dígitos do campo é igual ao limite.
        /// </summary>
        /// <param name="valor">valor do inteiro</param>
        /// <param name="limite">Limite do campo</param>
        /// <param name="tokenNomeCampo">Token do nome do campo para Mensagem</param>
        /// <param name="retornoValidacao">Rotorno da Validação</param>
        private static void ValidarValorIgual(int valor, int limite, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            string valorConvert = Convert.ToString(valor, CultureInfo.CurrentCulture);

            if (!string.IsNullOrEmpty(valorConvert) && (valorConvert.Length != limite))
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgValorIgual", tokenNomeCampo, limite));
            }
        }

        #endregion

        #region ValidarValorMin

        /// <summary>
        /// Valida a quantidade minima de itens da lista.
        /// </summary>
        /// <typeparam name="T">Type do elemento da lista.</typeparam>
        /// <param name="lista">Lista que sera validada.</param>
        /// <param name="limiteMin">Limite Mínimo da lista.</param>  
        /// <param name="tokenNomeCampo">Token do nome do campo para Mensagem</param>
        /// <param name="retornoValidacao">Rotorno da Validadção</param>
        private static void ValidarValorMinLista<T>(IList<T> lista, float limiteMin, string tokenNomeCampo, RetornoValidacao retornoValidacao)
            where T : class
        {
            if ((lista == null) || (lista.Count < limiteMin))
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgInformarMinimo", tokenNomeCampo, limiteMin));
            }
        }

        /// <summary>
        /// Valida a quantidade minima de itens da lista.
        /// </summary>
        /// <param name="lista">Lista que sera validada.</param>
        /// <param name="limiteMin">Limite Mínimo da lista.</param>  
        /// <param name="tokenNomeCampo">Token do nome do campo para Mensagem</param>
        /// <param name="retornoValidacao">Rotorno da Validadção</param>
        private static void ValidarValorMinLista(IList lista, float limiteMin, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            if ((lista == null) || (lista.Count < limiteMin))
            {
                retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgInformarMinimo", tokenNomeCampo, limiteMin));
            }
        }

        #endregion

        #region ValidaCaracterInvalido
        /// <summary>
        /// Valida Caracteres inválidos
        /// </summary>
        /// <param name="stringEntrada">Valida a  String de Entrada verificando se possui caracteres especiais</param>
        /// <param name="tokenNomeCampo">Token do Nome Para Mensagem</param>
        /// <param name="retornoValidacao">Rotorno da Validadção</param>
        private static void ValidaCaracterInvalido(string stringEntrada, string tokenNomeCampo, RetornoValidacao retornoValidacao)
        {
            if (!string.IsNullOrWhiteSpace(stringEntrada))
            {
                string strEnt = stringEntrada.Replace(" ", string.Empty);

                string stringCaracteresInvalidos = "!.@.#.$.%.&.*.(.)._.-.+.=";

                char[] c = ".".ToCharArray(0, 1);

                string[] str = stringCaracteresInvalidos.Split(c);

                foreach (string caracter in str)
                {
                    if (strEnt.ToUpper(CultureInfo.CurrentCulture).IndexOf(@caracter, StringComparison.CurrentCulture) > 0)
                    {
                        retornoValidacao.AddMensagem(String.Format("MENSAGEM VALIDACAO MsgCaracterInvalido", tokenNomeCampo));
                    }
                }
            }
        }

        #endregion
    }
}

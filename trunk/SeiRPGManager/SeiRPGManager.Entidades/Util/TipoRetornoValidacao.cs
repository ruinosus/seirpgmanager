using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Util
{
    /// <summary>
    /// Classe que representa a entidade tipo de retorno da validação.
    /// </summary>
    public enum TipoRetornoValidacao : int
    {
        /// <summary>
        /// Indica o tipo de retorno da validação como Nenhum.
        /// </summary>
        Nenhum = 1,

        /// <summary>
        /// Indica o tipo de retorno da validação como RegistrarMensagens.
        /// </summary>
        RegistrarMensagens = 2,

        /// <summary>
        /// Indica o tipo de retorno da validação como LevantarExcecao.
        /// </summary>
        LevantarExcecao = 3,
    }
}

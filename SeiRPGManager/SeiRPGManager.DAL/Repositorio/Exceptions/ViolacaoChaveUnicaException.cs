using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Storytelling.Negocio.Excecoes
{
    public class ViolacaoChaveUnicaException : SeiRPGManagerException
    {
        public ViolacaoChaveUnicaException(Exception innerException) :
            base("O item não pode ser cadastrado, pois já existe informação semelhante", innerException)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Storytelling.Negocio.Excecoes
{
    public class ViolacaoReferenciaException : SeiRPGManagerException
    {
        public ViolacaoReferenciaException(Exception innerException) :
            base("O item não pode ser excluido pois está referenciado nos demais cadastros", innerException)
        {

        }
    }
}

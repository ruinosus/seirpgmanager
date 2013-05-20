using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeiRPGManager.Negocio.Exceptions
{
    public class SeiRPGManagerException : Exception
    {
        public SeiRPGManagerException()
        {

        }

        public SeiRPGManagerException(string message) :
            base(message)
        {

        }

        public SeiRPGManagerException(string message, Exception innerException) :
            base(message, innerException)
        {

        }
    }
}

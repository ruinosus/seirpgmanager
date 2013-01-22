using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Diagnostics;

namespace SeiRPGManager.Negocio
{
    public static class GerenciadorContexto
    {
        static GerenciadorContexto()
        {
            Nome = typeof(PersistenciaContext).Name;
        }

        public static ObjectContext ObjectContext
        {
            get 
            {
                return (new PersistenciaContext() as IObjectContextAdapter).ObjectContext;  
            }
        }

        public static string Nome { get; private set; }
    }
}

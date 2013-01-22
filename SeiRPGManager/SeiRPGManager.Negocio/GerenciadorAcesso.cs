// -----------------------------------------------------------------------
// <copyright file="GerenciadorAcesso.cs" company="SeiRPGManager">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Negocio
{
    using SeiRPGManager.Entidades;
    using System.Threading;
    using System.Text;
    using System.Security.Cryptography;

    public static class GerenciadorAcesso
    {
        public static string Cifrar(string informacao)
        {
            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
            SHA1Managed sha1Managed = new SHA1Managed();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in sha1Managed.ComputeHash(unicodeEncoding.GetBytes(informacao)))
	        {
		        stringBuilder.AppendFormat("{0:x2}", item);
	        }

            return stringBuilder.ToString();
        }

        public static bool UsuarioCorrentePertence(Tipo tipo)
        {
            bool pertence = false;

            switch (tipo)
            {
                case Tipo.Narrador:
                case Tipo.Editor:
                case Tipo.Administrador:
                    pertence = Thread.CurrentPrincipal.IsInRole(tipo.ToString());
                    break;
            }

            return pertence;
        }
    }
}

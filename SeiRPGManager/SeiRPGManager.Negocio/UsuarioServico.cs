// -----------------------------------------------------------------------
// <copyright file="UsuarioServico.cs" company="Storytelling">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace Storytelling.Negocio
{
    using System.Linq;
    using Storytelling.Entidades;
    using Storytelling.Modelos;
    using System.Data.Objects;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class UsuarioServico : BaseServico<Usuario, UsuarioFormModel>
    {
        internal UsuarioServico()
        {

        }

        public override void Salvar(UsuarioFormModel model)
        {
            if (model.Resetar || model.Id == 0)
            {
                model.Entidade.Senha = GerenciadorAcesso.Cifrar(model.Login);
            }

            if (string.IsNullOrEmpty(model.Entidade.Senha))
            {
                model.Entidade.Senha = Consultar(model.Id.Value).Senha;
            }

            base.Salvar(model);

            SistemaSemAdministrador();
        }

        public override void Excluir(params long[] ids)
        {
            base.Excluir(ids);

            SistemaSemAdministrador();
        }

        public void CriarConta(CriarContaModel model)
        {
            using (var context = Context)
            {
                context.CreateObjectSet<Usuario>().AddObject(new Usuario
                {
                    Nome = model.Nome,
                    Login = model.Login,
                    Email = model.Email,
                    Inativado = false,
                    Tipo = model.Narrador ? Tipo.Narrador : Tipo.Jogador,
                    Senha = GerenciadorAcesso.Cifrar(model.Senha)
                });

                SalvarContexto(context);
            }
        }

        public bool MudarSenha(MudarSenhaModel model, string login)
        {
            if (login.Equals("Storytelling"))
            {
                return false;
            }

            model.SenhaAtual = GerenciadorAcesso.Cifrar(model.SenhaAtual);
            model.SenhaNova = GerenciadorAcesso.Cifrar(model.SenhaNova);

            using (var context = Context)
            {
                var usuario = context.CreateObjectSet<Usuario>().Single(usu => usu.Login.Equals(login));

                if (usuario.Senha.Equals(model.SenhaAtual))
                {
                    usuario.Senha = model.SenhaNova;

                    SalvarContexto(context);

                    return true;
                }
            }

            return false;
        }

        public bool ValidarUsuario(LogarModel model)
        {
            using (var context = Context)
            {
                var usuario = context.CreateObjectSet<Usuario>().SingleOrDefault(usu => usu.Login.Equals(model.Login));

                if (usuario != null && !usuario.Inativado.Value && usuario.Senha.Equals(model.Senha))
                {
                    return true;
                }
            }

            return false;
        }

        public void SistemaSemAdministrador()
        {
            using (var context = Context)
            {
                ObjectSet<Usuario> objectSet = context.CreateObjectSet<Usuario>();
                if (objectSet.Where(usu => usu.TipoEnum == (int?) Tipo.Administrador && usu.Inativado == false).Count() == 0)
                {
                    Usuario usuario = new Usuario();
                    usuario.Login = "Storytelling";
                    usuario.Nome = "Storytelling";
                    usuario.Email = "storytelling@web.com";
                    usuario.Senha = "b007aed385c5e2023beed247f967f1bfb09cd651";
                    usuario.Inativado = false;
                    usuario.Tipo = Tipo.Administrador;

                    objectSet.AddObject(usuario);

                    SalvarContexto(context);
                }
            }
        }

        public Usuario Consultar(string login)
        {
            using (var context = Context)
            {
                return context.CreateObjectSet<Usuario>().SingleOrDefault(usu => usu.Login.Equals(login));
            }
        }
    }
}

using SeiRPGManager.DAL.Repositorio;
using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using SeiRPGManager.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Negocio
{
    public class SeiRPGManagerNegocio<T> : ISeiRPGManagerNegocio<T> where T : Entidade
    {
        private SeiRPGManagerNegocio<T> seiRPGManagerNegocio;

        public SeiRPGManagerNegocio()
        {
            this.seiRPGManagerNegocio = new SeiRPGManagerNegocio<T>();
        }

        public List<T> ObterTodos<T>() where T : Entidade
        {
            return this.seiRPGManagerNegocio.ObterTodos<T>();
        }

        public void Atualizar<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerNegocio.Atualizar<T>(entidade);
        }

        public void Inserir<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerNegocio.Inserir<T>(entidade);
        }

        public void Excluir<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerNegocio.Excluir<T>(entidade);
        }

        public void Excluir<T>(params long[] ids) where T : Entidade
        {
            this.seiRPGManagerNegocio.Excluir<T>(ids);
        }

        public void Anexar<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerNegocio.Anexar<T>(entidade);
        }

        public IQueryable<T> Pesquisar<T>() where T : Entidade
        {
            return this.seiRPGManagerNegocio.Pesquisar<T>();
        }

        public IQueryable<T> Pesquisar<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerNegocio.Pesquisar<T>(filtro);
        }

        public T ObterUm<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerNegocio.ObterUm<T>(filtro);
        }

        public T ObterPrimeiro<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerNegocio.ObterPrimeiro<T>(filtro);
        }
    }
}

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
    public class SeiRPGManagerNegocios<T> : ISeiRPGManagerNegocio<T> where T : Entidade
    {
        private SeiRPGManagerDAO<T> seiRPGManagerDAO;

        public SeiRPGManagerNegocios()
        {
            this.seiRPGManagerDAO = new SeiRPGManagerDAO<T>();
        }

        public List<T> ObterTodos<T>() where T : Entidade
        {
            return this.seiRPGManagerDAO.ObterTodos<T>();
        }

        public void Atualizar<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerDAO.Atualizar<T>(entidade);
        }

        public void Inserir<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerDAO.Inserir<T>(entidade);
        }

        public void Excluir<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerDAO.Excluir<T>(entidade);
        }

        public void Excluir<T>(params long[] ids) where T : Entidade
        {
            this.seiRPGManagerDAO.Excluir<T>(ids);
        }

        public void Anexar<T>(T entidade) where T : Entidade
        {
            this.seiRPGManagerDAO.Anexar<T>(entidade);
        }

        public IEnumerable<T> Pesquisar<T>() where T : Entidade
        {
            return this.seiRPGManagerDAO.Pesquisar<T>();
        }

        public IEnumerable<T> Pesquisar<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerDAO.Pesquisar<T>(filtro);
        }

        public T ObterUm<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerDAO.ObterUm<T>(filtro);
        }

        public T ObterPrimeiro<T>(Func<T, bool> filtro) where T : Entidade
        {
            return this.seiRPGManagerDAO.ObterPrimeiro<T>(filtro);
        }
    }
}

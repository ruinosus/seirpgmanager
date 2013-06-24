// -----------------------------------------------------------------------
// <copyright file="ISeiRPGManagerNegocio.cs" company="Playware">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Negocio.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using SeiRPGManager.Entidades.Modelo.ClassesBasicas;

    /// <summary>
    /// Todo Atualizar
    /// </summary>
    /// <typeparam name="T">Entidade genérica</typeparam>
    public interface ISeiRPGManagerNegocio<T>
        where T : Entidade
    {
        List<T> ObterTodos<T>() where T : Entidade;        
        void Atualizar<T>(T entidade) where T : Entidade;
        void Inserir<T>(T entidade) where T : Entidade;
        void Excluir<T>(T entidade) where T : Entidade;
        void Excluir<T>(params long[] ids) where T : Entidade;
        void Anexar<T>(T entidade) where T : Entidade;
        IQueryable<T> Pesquisar<T>() where T : Entidade;
        IQueryable<T> Pesquisar<T>(Func<T, bool> filtro) where T : Entidade;
        T ObterUm<T>(Func<T, bool> filtro) where T : Entidade;
        T ObterPrimeiro<T>(Func<T, bool> filtro) where T : Entidade;        
    }
}

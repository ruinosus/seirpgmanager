// -----------------------------------------------------------------------
// <copyright file="ISeiRPGManagerDAO.cs" company="Playware">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.DAL.Repositorio.Interface
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
    public interface ISeiRPGManagerDAO<T>
        where T : Entidade
    {
        /// <summary>
        /// TODO: Atualizar Header
        /// </summary>
        /// <returns>Retorna uma lista IQuerable tipada da entidade pertinente</returns>
        IQueryable<T> ObterTodos();

        /// <summary>
        /// TODO: Atualizar Header
        /// </summary>
        /// <param name="entidade">Entidade a ser persistida</param>
        void InserirOuAtualizar(T entidade);

        /// <summary>
        /// TODO: Atualizar Header
        /// </summary>
        /// <param name="entidade">Entidade a ser atualizada</param>
        void Atualizar(T entidade);

        /// <summary>
        /// TODO: Atualizar Header
        /// </summary>
        /// <param name="ids">arrays de códigos que devem ser excluídos da base</param>
        /// <returns>Retorna true se bem-sucedido e false se mal-sucedido</returns>
        bool Excluir(params long[] ids);

        /// <summary>
        /// TODO: Atualizar Header
        /// </summary>
        /// <param name="filtro">Filtro usando expressões lambda</param>
        /// <returns>Retorna uma lista tipada da entidade pertinente</returns>
        IQueryable<T> Pesquisar(Expression<Func<T, bool>> filtro);
    }
}

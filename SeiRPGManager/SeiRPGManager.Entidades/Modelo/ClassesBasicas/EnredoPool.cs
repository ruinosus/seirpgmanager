// -----------------------------------------------------------------------
// <copyright file="EnredoPool.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por armazenar os enredos de exemplo para os jogadores</summary>
	public class EnredoPool: Entidade
	{
	    public EnredoPool()
		{
			this.Categorias = new List<Categoria>();
		}

		public string Titulo { get; set; }

		public string Conteudo { get; set; }

		public virtual ICollection<Categoria> Categorias { get; set; }
	}
}


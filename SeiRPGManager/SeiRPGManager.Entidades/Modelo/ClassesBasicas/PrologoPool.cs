// -----------------------------------------------------------------------
// <copyright file="PrologoPool.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por armazenar os prologos usados como pool para os jogadores</summary>
	public class PrologoPool: Entidade
	{
	    public PrologoPool()
		{
			this.Categorias = new List<Categoria>();
		}

		public string Conteudo { get; set; }

		public int? QuantidadeJogadores { get; set; }

		public virtual ICollection<Categoria> Categorias { get; set; }
	}
}


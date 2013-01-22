// -----------------------------------------------------------------------
// <copyright file="Sistema.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar os sistemas de RPG existentes para serem jogados</summary>
	public class Sistema: Entidade
	{
	    public Sistema()
		{
			this.Campanhas = new List<Campanha>();
		}

		public string Nome { get; set; }

		public string Versao { get; set; }

		public string ModeloPlanilha { get; set; }

		public virtual ICollection<Campanha> Campanhas { get; set; }
	}
}


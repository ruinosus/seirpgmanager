// -----------------------------------------------------------------------
// <copyright file="Habilitador.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar os habilitadores especiais das raças dos seres do SubMundo</summary>
	public class Habilitador: Entidade
	{
	    public Habilitador()
		{
			this.Especializacoes = new List<Especializacao>();
		}

		public string Nome { get; set; }

		public string Descricao { get; set; }

		public virtual ICollection<Especializacao> Especializacoes { get; set; }
	}
}


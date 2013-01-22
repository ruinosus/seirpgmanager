// -----------------------------------------------------------------------
// <copyright file="Anotacao.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por armazenar as anotações escritas pelos jogadores</summary>
	public class Anotacao: Entidade
	{
		public long CampanhaId { get; set; }

		public long PersonagemId { get; set; }

		public string Conteudo { get; set; }

		public virtual Personagem Personagem { get; set; }

		public virtual Campanha Campanha { get; set; }
	}
}


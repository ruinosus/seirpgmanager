// -----------------------------------------------------------------------
// <copyright file="Especializacao.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar as especializações dos habilitadores especiais das raças do SubMundo</summary>
	public class Especializacao: Entidade
	{
        public long HabilitadorId { get; set; }

		public string Nome { get; set; }

		public string Descricao { get; set; }

		public virtual Habilitador Habilitador { get; set; }
	}
}


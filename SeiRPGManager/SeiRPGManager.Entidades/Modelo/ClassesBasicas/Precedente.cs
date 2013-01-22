// -----------------------------------------------------------------------
// <copyright file="Precedente.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar os precedentes que o personagem possui</summary>
	public class Precedente: Entidade
	{
		public string Nome { get; set; }

		public string Descricao { get; set; }

        public int? Custo { get; set; }
	}
}


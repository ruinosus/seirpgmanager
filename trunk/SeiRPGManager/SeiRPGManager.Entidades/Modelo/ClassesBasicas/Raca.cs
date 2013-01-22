// -----------------------------------------------------------------------
// <copyright file="Raca.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar as raças do SubMundo</summary>
	public class Raca: Entidade
	{
		public string Nome { get; set; }

        public string Descricao { get; set; }
	}
}


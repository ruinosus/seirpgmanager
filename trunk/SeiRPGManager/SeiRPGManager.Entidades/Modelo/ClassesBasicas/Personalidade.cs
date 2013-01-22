// -----------------------------------------------------------------------
// <copyright file="Personalidade.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar as personalidades dos personagens</summary>
	public class Personalidade: Entidade
	{
		public string Nome { get; set; }

		public string Sigla { get; set; }

		public string Descricao { get; set; }
	}
}


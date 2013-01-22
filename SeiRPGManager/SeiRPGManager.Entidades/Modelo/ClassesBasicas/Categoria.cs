// -----------------------------------------------------------------------
// <copyright file="Agenda.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por armazenar as tags de categoria para os pools EnredoPool, NomePool e PrologoPool</summary>
	public class Categoria: Entidade
	{		
		public long? PrologoPoolId { get; set; }

		public long? NomePoolId { get; set; }

		public long? EnredoPoolId { get; set; }

		public string Descricao { get; set; }

        public virtual EnredoPool EnredoPool { get; set; }

        public virtual NomePool NomePool { get; set; }

        public virtual PrologoPool PrologoPool { get; set; }
	}
}


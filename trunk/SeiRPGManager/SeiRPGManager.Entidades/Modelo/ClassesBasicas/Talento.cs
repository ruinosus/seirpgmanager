// -----------------------------------------------------------------------
// <copyright file="Talento.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Entidades.Modelo.Enum;

    /// <summary>Classe responsável por gerenciar os talentos que o personagem possui</summary>
	public class Talento: Entidade
	{
		public string Nome { get; set; }

		public string Descricao { get; set; }

        public Ajuste? AjusteEnum
        {
            get { return (Ajuste?)Ajuste; }
            set { Ajuste = (int?)value; }
        }

        private int? Ajuste { get; set; }
	}
}


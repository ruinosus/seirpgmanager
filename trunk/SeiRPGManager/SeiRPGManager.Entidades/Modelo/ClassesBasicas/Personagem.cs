// -----------------------------------------------------------------------
// <copyright file="Personagem.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Entidades.Modelo;
    using SeiRPGManager.Modelos.Enum;

    /// <summary>Classe responsável por gerenciar os personagens que interagirão com o sistema</summary>
	public class Personagem: Entidade
	{
		public long? CampanhaId { get; set; }

		public long JogadorId { get; set; }

		public string Planilha { get; set; }

        public string BreveDescricao { get; set; }

		public string Historia { get; set; }

		public byte[] Foto { get; set; }

		public virtual ICollection<Anotacao> Anotacoes { get; set; }

		public virtual Campanha Campanha { get; set; }

		public virtual Jogador Jogador { get; set; }

        public TipoPersonagem? TipoPersonagemEnum
        {
            get { return (TipoPersonagem?)TipoPersonagem; }
            set { TipoPersonagem = (int?)value; }
        }

        private int? TipoPersonagem { get; set; }

        public Personagem()
        {
            this.Anotacoes = new List<Anotacao>();
        }

	}
}


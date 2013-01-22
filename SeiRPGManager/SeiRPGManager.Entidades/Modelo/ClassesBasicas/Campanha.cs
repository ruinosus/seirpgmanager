// -----------------------------------------------------------------------
// <copyright file="Campanha.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Modelos.Enum;

    /// <summary>Classe responsável por gerenciar as campanhas jogadas e mestradas por jogadores</summary>
	public class Campanha: Entidade
	{
		public long MestreId { get; set; }

		public long SistemaId { get; set; }

		public string Nome { get; set; }

		public string Descricao { get; set; }

		public int? CapituloAtual { get; set; }

		public virtual ICollection<Agenda> Agenda { get; set; }

		public virtual ICollection<Anotacao> Anotacoes { get; set; }

		public virtual Sistema Sistema { get; set; }

		public virtual Jogador Jogador { get; set; }

		public virtual ICollection<Personagem> Personagens { get; set; }

        public SituacaoCampanha? SituacaoEnum
        {
            get { return (SituacaoCampanha?)Situacao; }
            set { Situacao = (int?)value; }
        }

        private int? Situacao { get; set; }

        public Campanha()
        {
            this.Agenda = new List<Agenda>();
            this.Anotacoes = new List<Anotacao>();
            this.Personagens = new List<Personagem>();
        }
	}
}


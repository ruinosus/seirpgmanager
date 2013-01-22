// -----------------------------------------------------------------------
// <copyright file="Jogador.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Modelos.Enum;

    /// <summary>Classe responsável por gerenciar os jogadores que irão participar das campanhas</summary>
	public class Jogador: Entidade
	{
		public string Nome { get; set; }

		public string Email { get; set; }

		public string Facebook { get; set; }

		public string Twitter { get; set; }

		public virtual ICollection<Campanha> Campanhas { get; set; }

        public virtual ICollection<Mensagem> MensagensEnviadas { get; set; }

        public virtual ICollection<Mensagem> MensagensRecebidas { get; set; }

		public virtual ICollection<Personagem> Personagens { get; set; }

        public SituacaoJogador? SituacaoJogadorEnum
        {
            get { return (SituacaoJogador?)Situacao; }
            set { Situacao = (int?)value; }
        }

        private int? Situacao { get; set; }

        public Jogador()
        {
            this.Campanhas = new List<Campanha>();
            this.MensagensEnviadas = new List<Mensagem>();
            this.MensagensRecebidas = new List<Mensagem>();
            this.Personagens = new List<Personagem>();
        }
	}
}


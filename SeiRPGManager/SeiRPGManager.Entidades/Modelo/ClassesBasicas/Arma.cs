// -----------------------------------------------------------------------
// <copyright file="Arma.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Entidades.Modelo.Enum;

    /// <summary>Classe responsável por gerenciar as armas carregadas pelos personagens</summary>
	public class Arma: Entidade
	{
		public string Nome { get; set; }	

        public int? Custo { get; set; }

		public int? Municao { get; set; }

		public string Descricao { get; set; }

        public byte[] Imagem { get; set; }

        public Tamanho? TamanhoEnum
        {
            get { return (Tamanho?)Tamanho; }
            set { Tamanho = (int?)value; }
        }

        private int? Tamanho { get; set; }

        public Ajuste? AjusteEnum
        {
            get { return (Ajuste?)Ajuste; }
            set { Ajuste = (int?)value; }
        }

		private int? Ajuste { get; set; }
                
        public Alcance? AlcanceEnum
        {
            get { return (Alcance?)Alcance; }
            set { Alcance = (int?)value; }
        }

        private int? Alcance { get; set; }      

        public TipoDano? TipoDanoEnum
        {
            get { return (TipoDano?)TipoDano; }
            set { TipoDano = (int?)value; }
        }

        private int? TipoDano { get; set; }       
	}
}


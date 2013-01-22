// -----------------------------------------------------------------------
// <copyright file="NomePool.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
    using SeiRPGManager.Entidades.Modelo.Enum;

    /// <summary>Classe responsável por armazenar os nomes usados para Pool</summary>
	public class NomePool: Entidade
	{
		public string Nome { get; set; }

        public Sexo? SexoEnum
        {
            get { return (Sexo?)Sexo; }
            set { Sexo = (int?)value; }
        }

        private int? Sexo { get; set; }

        public Nacionalidade? NacionalidadeEnum
        {
            get { return (Nacionalidade?)Nacionalidade; }
            set { Nacionalidade = (int?)value; }
        }

		private int? Nacionalidade { get; set; }

		public virtual ICollection<Categoria> Categorias { get; set; }

        public NomePool()
        {
            this.Categorias = new List<Categoria>();
        }
	}
}


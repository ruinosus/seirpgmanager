// -----------------------------------------------------------------------
// <copyright file="Mensagem.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
	using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por armazenar as mensagens trocadas entre os jogadores</summary>
    public class Mensagem: Entidade
	{
		public long ReceptorId { get; set; }
		public long EmissorId { get; set; }
		public string Conteudo { get; set; }
		public string Titulo { get; set; }
		public virtual Jogador Emissor { get; set; }
		public virtual Jogador Receptor { get; set; }
	}
}


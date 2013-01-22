// -----------------------------------------------------------------------
// <copyright file="Agenda.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;

    /// <summary>Classe responsável por gerenciar a agenda dos jogadores em uma partida</summary>
	public class Agenda: Entidade
	{		
		public long CampanhaId { get; set; }

		public Nullable<System.DateTime> DataPartida { get; set; }

		public Nullable<System.DateTime> HoraPartida { get; set; }

		public string Lugar { get; set; }

		public virtual Campanha Campanha { get; set; }
	}
}


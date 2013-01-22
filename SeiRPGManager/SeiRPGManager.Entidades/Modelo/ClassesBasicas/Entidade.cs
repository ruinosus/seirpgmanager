// -----------------------------------------------------------------------
// <copyright file="Entidade.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>Classe mãe das demais</summary>
    public class Entidade
    {
        public long Id { get; set; }
    }
}

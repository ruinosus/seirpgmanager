// -----------------------------------------------------------------------
// <copyright file="PersistenciaContext.cs" company="SeiRPGManager">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Negocio
{
    using System.Data.Entity;
    using SeiRPGManager.Entidades;
    using SeiRPGManager.Entidades.VTR;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    internal class PersistenciaContext : DbContext 
    {
        static PersistenciaContext()
        {
            //Database.SetInitializer<PersistenciaContext>(new DropCreateDatabaseIfModelChanges<PersistenciaContext>());
        }

        public PersistenciaContext()
            : base("name=SeiRPGManagerCon")
        {

        }

        public DbSet<Agrupamento> Agrupamento { get; set; }

        public DbSet<Arma> Arma { get; set; }

        public DbSet<Cla> Cla { get; set; }

        public DbSet<ClaDisciplina> ClaDisciplina { get; set; }

        public DbSet<Cronica> Cronica { get; set; }

        public DbSet<Devocao> Devocao { get; set; }

        public DbSet<DevocaoDisciplina> DevocaoDisciplina { get; set; }

        public DbSet<Disciplina> Disciplina { get; set; }

        public DbSet<Especializacao> Especializacao { get; set; }

        public DbSet<Humano> Humano { get; set; }

        public DbSet<HumanoArma> HumanoArma { get; set; }

        public DbSet<HumanoEspecializacao> HumanoEspecializacao { get; set; }

        public DbSet<HumanoItem> HumanoItem { get; set; }

        public DbSet<HumanoVantagem> HumanoVantagem { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<Ritual> Ritual { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Vampiro> Vampiro { get; set; }

        public DbSet<VampiroDevocao> VampiroDevocao { get; set; }

        public DbSet<VampiroDisciplina> VampiroDisciplina { get; set; }

        public DbSet<VampiroRitual> VampiroRitual { get; set; }

        public DbSet<Vantagem> Vantagem { get; set; }

        public DbSet<VantagemCampo> VantagemCampo { get; set; }

        public DbSet<VantagemNivel> VantagemNivel { get; set; }
    }
}

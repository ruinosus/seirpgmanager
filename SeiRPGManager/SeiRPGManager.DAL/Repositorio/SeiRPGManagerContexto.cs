// -----------------------------------------------------------------------
// <copyright file="SeiRPGManagerContexto.cs" company="Playware">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.DAL.Repositorio
{
    using System.Data.Entity;
    using System.Data.Objects;    
    using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;

    /// <summary>
    /// TODO: Update Header
    /// </summary>
    public class SeiRPGManagerContexto : DbContext
    {
        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public SeiRPGManagerContexto() : base("name=SeiRPGManagerCon")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Agenda> Agendas { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Anotacao> Anotacoes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Arma> Armas { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Campanha> Campanhas { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Categoria> Categorias { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<EnredoPool> Enredos { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Equipamento> Equipamentos { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Especializacao> Especializacoes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Habilitador> Habilitadores { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Jogador> Jogadores { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Mensagem> Mensagens { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<NomePool> Nomes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Ocupacao> Ocupacoes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Parametro> Parametros { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Personagem> Personagens { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Personalidade> Personalidades { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Precedente> Precedentes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<PrologoPool> Prologos { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Raca> Racas { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Saude> Saudes { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Sistema> Sistemas { get; set; }

        /// <summary>
        /// TODO: Update Header
        /// </summary>
        public DbSet<Talento> Talentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Instructor>()
            //    .HasOptional(p => p.OfficeAssignment).WithRequired(p => p.Instructor);
            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Instructors).WithMany(i => i.Courses)
            //    .Map(t => t.MapLeftKey("CourseID")
            //        .MapRightKey("PersonID")
            //        .ToTable("CourseInstructor"));
            //modelBuilder.Entity<Department>()
            //    .HasOptional(x => x.Administrator);
        }
    }
}

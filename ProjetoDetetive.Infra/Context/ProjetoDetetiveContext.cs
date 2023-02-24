using Microsoft.EntityFrameworkCore;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;
using ProjetoDetetive.Infra.Mapping.ProjetoDetetive;

namespace ProjetoDetetive.Infra.Context
{
    public sealed class ProjetoDetetiveContext : DbContext
    {
        public ProjetoDetetiveContext(DbContextOptions<ProjetoDetetiveContext> options) : base(options)
        {
        }

        public DbSet<SuspeitoEntity> Suspeito { get; set; }
        public DbSet<LocalEntity> Local { get; set; }
        public DbSet<ArmaEntity> Arma { get; set; }
        public DbSet<AssassinatoEntity> Assassinato { get; set; }

        private static void ModuloDetetive(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SuspeitoMapping());
            modelBuilder.ApplyConfiguration(new ArmaMapping());
            modelBuilder.ApplyConfiguration(new LocalMapping());
            modelBuilder.ApplyConfiguration(new AssassinatoMapping());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModuloDetetive(modelBuilder);
        }
    }
}

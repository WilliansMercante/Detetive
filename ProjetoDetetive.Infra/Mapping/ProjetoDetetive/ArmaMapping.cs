using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Infra.Mapping.ProjetoDetetive
{
    internal sealed class ArmaMapping : IEntityTypeConfiguration<ArmaEntity>
    {
        public void Configure(EntityTypeBuilder<ArmaEntity> builder)
        {
            builder.ToTable("TB_ARMA");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_ARMA");
            builder.Property(p => p.Nome).HasColumnName("NM_ARMA");
        }
    }
}

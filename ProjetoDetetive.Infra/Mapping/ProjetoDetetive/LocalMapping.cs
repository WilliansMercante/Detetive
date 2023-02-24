using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Infra.Mapping.ProjetoDetetive
{
    internal sealed class LocalMapping : IEntityTypeConfiguration<LocalEntity>
    {
        public void Configure(EntityTypeBuilder<LocalEntity> builder)
        {
            builder.ToTable("TB_LOCAL");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_LOCAL");
            builder.Property(p => p.Nome).HasColumnName("NM_LOCAL");
        }
    }
}

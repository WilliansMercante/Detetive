using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Infra.Mapping.ProjetoDetetive
{
    internal sealed class SuspeitoMapping : IEntityTypeConfiguration<SuspeitoEntity>
    {
        public void Configure(EntityTypeBuilder<SuspeitoEntity> builder)
        {
            builder.ToTable("TB_SUSPEITO");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_SUSPEITO");
            builder.Property(p => p.Nome).HasColumnName("NM_SUSPEITO");            
        }
    }
}

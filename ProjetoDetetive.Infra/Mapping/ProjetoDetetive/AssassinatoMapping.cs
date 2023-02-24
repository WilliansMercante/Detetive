using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ProjetoDetetive.Dominio.ProjetoDetetive.Entidades;

namespace ProjetoDetetive.Infra.Mapping.ProjetoDetetive
{
    internal sealed class AssassinatoMapping : IEntityTypeConfiguration<AssassinatoEntity>
    {
        public void Configure(EntityTypeBuilder<AssassinatoEntity> builder)
        {
            builder.ToTable("TB_ASSASSINATO");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_ASSASSINATO");
            builder.Property(p => p.IdArma).HasColumnName("ID_ARMA");
            builder.Property(p => p.IdLocal).HasColumnName("ID_LOCAL");
            builder.Property(p => p.IdSuspeito).HasColumnName("ID_SUSPEITO");
            builder.Property(p => p.DtCadastro).HasColumnName("DT_CADASTRO");

            builder.HasOne(p => p.Arma).WithMany().HasForeignKey(p => p.IdArma);
            builder.HasOne(p => p.Local).WithMany().HasForeignKey(p => p.IdLocal);
            builder.HasOne(p => p.Suspeito).WithMany().HasForeignKey(p => p.IdSuspeito);
        }
    }
}

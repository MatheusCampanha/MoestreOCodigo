using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MostreOCodigo.Domain.Models;

namespace MostreOCodigo.Data.Mappings
{
    public class ValorMapping : IEntityTypeConfiguration<Valor>
    {
        public void Configure(EntityTypeBuilder<Valor> builder)
        {
            builder.HasKey(v => v.ValorId);

            builder.Property(v => v.Origem)
                .IsRequired();

            builder.Property(v => v.Destino)
                .IsRequired();

            builder.Property(v => v.ValorMinuto)
                .IsRequired();
        }
    }
}

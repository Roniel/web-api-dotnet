using AppWebApiEstudo.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppWebApiEstudo.Infra.Data.EntitiesConfiguration
{
    public class BeneficiarioConfiguration: IEntityTypeConfiguration<Beneficiario>
    {
        public void Configure(EntityTypeBuilder<Beneficiario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
        }
    }
}

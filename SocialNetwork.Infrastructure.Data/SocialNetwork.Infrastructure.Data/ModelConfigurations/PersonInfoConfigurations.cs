using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Domain.Entities.Models.Base;

namespace SocialNetwork.Infrastructure.Data.ModelConfigurations
{
    internal class PersonInfoConfigurations : IEntityTypeConfiguration<PersonInfo>
    {
        public void Configure(EntityTypeBuilder<PersonInfo> builder)
        {
            builder.ToTable("Person");
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
        }
    }
}

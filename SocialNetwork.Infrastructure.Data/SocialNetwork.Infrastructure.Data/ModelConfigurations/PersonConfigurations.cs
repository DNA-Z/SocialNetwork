using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Domain.Entities.Models.Base;
using SocialNetwork.Domain.Entities.Models;

namespace SocialNetwork.Infrastructure.Data.ModelConfigurations
{
    internal class PersonConfigurations : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(30);
            builder.Property(p => p.DateOfBirth).IsRequired().HasColumnName("Birth Date").HasColumnType("datetime2");
            builder
                .HasMany(p => p.ChatRoom)
                .WithMany(r => r.People)
                .UsingEntity(j => j.ToTable("PeopleChatRoom"));
            //.HasForeignKey(p => p.ChatRoomId)
            //.OnDelete(DeleteBehavior.SetNull);
            //builder
            //    .HasOne(p => p.LogIn)
            //    .WithMany(l => l.People)


            Map(e =>
            {
                e.Property(at => new { at.Id, at.FirstName, at.LastName });
                e.ToTable("PersonName");
            });
        }
    }
}

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
            builder.Property(p => p.LastName).IsRequired();
            //builder
                //.HasOne(p => p.ChatRoom)
                //.WithMany(r => r. People)
                //.HasForeignKey(p => p.ChatRoomId)
                //.OnDelete(DeleteBehavior.SetNull);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Domain.Entities.Models.ChatbotModels;
using System.Collections.Generic;

namespace SocialNetwork.Infrastructure.Data.ModelConfigurations
{
    public class BotResponseDataConfiguration : IEntityTypeConfiguration<BotResponseData>
    {
        public void Configure(EntityTypeBuilder<BotResponseData> builder)
        {
            builder.ToTable("ResponseData");
        }
    }
}

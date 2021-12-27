using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Domain.Entities.Models.ChatbotModels;
using System.Collections.Generic;

namespace SocialNetwork.Infrastructure.Data.ModelConfigurations
{
    public class ResponseMSDataConfiguration : IEntityTypeConfiguration<ResponseMSData>
    {
        public void Configure(EntityTypeBuilder<ResponseMSData> builder)
        {
            builder.ToTable("ResponseData");
        }
    }
}

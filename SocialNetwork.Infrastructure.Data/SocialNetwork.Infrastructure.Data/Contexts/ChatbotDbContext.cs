using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.SqlClient;
using SocialNetwork.Domain.Entities.Models.ChatbotModels;


namespace SocialNetwork.Infrastructure.Data.Contexts
{
    public class ChatbotDbContext : DbContext
    {
        readonly string chatbotConnectString = ConfigurationManager.ConnectionStrings["ChatbotConnectionString"].ConnectionString;
        public virtual DbSet<ResponseData> chatbotResponse { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(chatbotConnectString);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities.Models.Base;
using SocialNetwork.Infrastructure.Data.ModelConfigurations;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SocialNetwork.Infrastructure.Data.Contexts
{
    public class SocialNetworkDbContext : DbContext
    {
        readonly string _socialNetworkConnectString = ConfigurationManager.ConnectionStrings["SocialNetworkConnectionString"].ConnectionString;

        public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_socialNetworkConnectString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfigurations());
            //modelBuilder.ApplyConfiguration(new BotResponseDataConfiguration());
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.ApplicationUseCases.Interfaces;
using SocialNetwork.ApplicationUseCases.Services;

namespace SocialNetwork.Infrastructure.IoC
{
    internal class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}

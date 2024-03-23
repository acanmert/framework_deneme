using framework_deneme.Dal;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace framework_deneme.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService (this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<PersonnelContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}

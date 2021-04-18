using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.Extensions;

namespace SharedKernel.Exceptions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddDataRepository(this IServiceCollection serviceCollection,
            Assembly[] assemblies)
        {
            const string marker = "Repository";
            return serviceCollection.ImplementService(marker, ServiceLifetime.Scoped, assemblies);
        }
    }
}
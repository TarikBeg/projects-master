using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SharedKernel.Extensions
{
    public static class CqrsExtension
    {
        public static IServiceCollection AddCommandHandlers(this IServiceCollection serviceCollection,
            Assembly[] assemblies)
        {
            return serviceCollection.AddMediatR(assemblies);
        }
    }
}
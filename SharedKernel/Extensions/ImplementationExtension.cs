using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace SharedKernel.Extensions
{
    public static class ImplementationExtension
    {
        public static IServiceCollection ImplementService(this IServiceCollection services, string marker,
            ServiceLifetime lifetime, Assembly[] assemblies)
        {
            var filter = new Func<Type, bool>(type => type.Name.Contains(marker));

            var assemblyServices = assemblies.SelectMany(assembly =>
                    assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterfaces().Any(filter) && !type.Name.Contains("Base")))
                .Select(x => new Tuple<Type, Type>(x, x.GetInterfaces().FirstOrDefault(filter)))
                .ToList();

            foreach (var (serviceAbstraction, servicesImplementation) in assemblyServices)
                switch (lifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(servicesImplementation, serviceAbstraction);
                        continue;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(servicesImplementation, serviceAbstraction);
                        continue;
                    case ServiceLifetime.Transient:
                        services.AddTransient(servicesImplementation, serviceAbstraction);
                        continue;
                }

            return services;
        }
    }
}
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Contexts;

namespace MistralTask.Extensions
{
    public static class CoreDbContextExtensions
    {
        public static IServiceCollection AddCoreDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            return service.AddScoped(provider => Build(provider, configuration));
        }

        private static CoreDbContext Build(IServiceProvider provider, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CoreDb");

            var builder = new DbContextOptionsBuilder<CoreDbContext>().UseSqlServer(connectionString);
            return new CoreDbContext(builder.Options);
        }

        public static IApplicationBuilder UseCoreDbContext(this IApplicationBuilder applicationBuilder)
        {
            using var scope = applicationBuilder.ApplicationServices.CreateScope();

            try
            {
                using var context = scope.ServiceProvider.GetService<CoreDbContext>();
                context.Database.Migrate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return applicationBuilder;
        }
    }
}
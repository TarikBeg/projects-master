using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MistralTask.Extensions
{
    public static class CorsExtension
    {
        public static IServiceCollection AddCorsExtension(this IServiceCollection service, IConfiguration configuration)
        {
            var origins = configuration.GetSection("Cors:Origins").Get<string>();
            if (string.IsNullOrWhiteSpace(origins))
            {
                throw new Exception("The configuration value 'Cors:Origins' cannot be null or empty.");
            }

            var urls = origins.Split(";");

            service.AddCors(o => o.AddPolicy("DefaultPolicy", builder =>
            {
                builder
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                    .WithOrigins(urls)
                    .AllowCredentials()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            return service;
        }

        public static IApplicationBuilder UseCorsExtension(this IApplicationBuilder app)
        {
            return app
                .UseCors("DefaultPolicy");
        }
    }
}
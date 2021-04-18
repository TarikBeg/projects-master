using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MistralTask.Extensions;
using Repository;
using SharedKernel.Exceptions;
using SharedKernel.Extensions;

namespace MistralTask
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var assemblies = new[] {Assembly.GetExecutingAssembly(), Assembly.GetAssembly(typeof(RepositoryAssembly))};

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "MistralTask", Version = "v1"});
            });

            services
                .AddCorsExtension(Configuration)
                .AddCommandHandlers(assemblies)
                .AddMapper(assemblies)
                .AddDataRepository(assemblies)
                .AddCoreDbContext(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MistralTask v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCorsExtension();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseCoreDbContext();
        }
    }
}
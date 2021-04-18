using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.Storage;

namespace SharedKernel.Extensions
{
    public static class StorageProviderExtensions
    {
        public static IServiceCollection AddAzureStorageProvider(this IServiceCollection service, IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("AzureBlobStorage:ConnectionString");
            var containerName = configuration.GetValue<string>("AzureBlobStorage:ContainerName");
            service.AddScoped<IStorageProvider<Blob, Uri>>(provider => new AzureBlobStorageProvider(connectionString, containerName));
            return service;
        }
    }
}
using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace SharedKernel.Storage
{
    public class AzureBlobStorageProvider : IStorageProvider<Blob, Uri>
    {
        private readonly CloudBlobContainer _cloudBlobContainer;

        public AzureBlobStorageProvider(string connectionString, string containerName)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var cloudBlobClient = storageAccount.CreateCloudBlobClient();
            _cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

            if (!_cloudBlobContainer.ExistsAsync().GetAwaiter().GetResult())
            {
                CreateContainer();
            }
        }

        public async Task<Uri> SaveAsync(Blob blob)
        {
            var cloudBlockBlob = _cloudBlobContainer.GetBlockBlobReference(blob.Name);
            await cloudBlockBlob.UploadFromStreamAsync(blob.Stream);
            return cloudBlockBlob.Uri;
        }

        private void CreateContainer()
        {
            _cloudBlobContainer.CreateAsync().GetAwaiter().GetResult();
            
            var permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };

            _cloudBlobContainer.SetPermissionsAsync(permissions).GetAwaiter().GetResult();
        }
    }
}
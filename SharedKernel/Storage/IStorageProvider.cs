using System.Threading.Tasks;

namespace SharedKernel.Storage
{
    public interface IStorageProvider<in TRequest, TResponse>
    {
        Task<TResponse> SaveAsync(TRequest blob);
    }
}
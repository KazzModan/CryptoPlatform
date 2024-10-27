namespace CryptoPlatform.Domain.REST;

public interface IApiRequestExecutor
{
    Task<TResponse> GetAsync<TResponse>(string request);
}
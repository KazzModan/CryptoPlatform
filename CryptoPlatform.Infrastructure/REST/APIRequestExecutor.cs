using CryptoPlatform.Domain.REST;
using System.Net.Http;
using Newtonsoft.Json;

namespace CryptoPlatform.Infrastructure.REST;

public class ApiRequestExecutor : IApiRequestExecutor
{
    private Uri _baseAddress = new Uri("https://api.coincap.io/v2/");

    public async Task<TResponse> GetAsync<TResponse>(string request)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = _baseAddress;
            var httpResponseMessage = await client.GetAsync(request);
            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<TResponse>(content);
            return response;
        };
    }
}
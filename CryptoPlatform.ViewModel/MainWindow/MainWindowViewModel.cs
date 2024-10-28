using CryptoPlatform.Domain.Cryptos;
using CryptoPlatform.Domain.REST;
using CryptoPlatform.ViewModel.DTO;

namespace CryptoPlatform.ViewModel.MainWindow;

public class MainWindowViewModel : IMainWindowViewModel
{
    private readonly IApiRequestExecutor _apiRequestExecutor;
    public IEnumerable<CryptoDTO> Items { get; private set; } =
        Enumerable.Empty<CryptoDTO>();
    public MainWindowViewModel(IApiRequestExecutor apiRequestExecutor)
    {
        _apiRequestExecutor = apiRequestExecutor;
    }
    public async Task LoadDataAsync()
    {
        var cryptosCollectionResponse = await _apiRequestExecutor.GetAsync<CryptoCollectionResponse>("assets?Limit=10");

        Items = cryptosCollectionResponse.Data.Select(response =>
            new CryptoDTO(response.Symbol, response.Name, response.ChangePercent24Hr, response.PriceUsd)).ToList();
    }
}
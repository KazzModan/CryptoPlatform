using System.Windows.Media;

namespace CryptoPlatform.ViewModel.DTO;

public class CryptoDTO
{
    private readonly string Path = "pack://application:,,,/CryptoPlatform.ViewModel;component/src/Images/";

    public CryptoDTO(string symbol, string name, double changePer24Hr, double priceUsd)
    {
        Symbol = symbol;
        Name = name;
        ChangePercent24Hr = changePer24Hr.ToString("N2");
        PriceUsd = priceUsd.ToString("N2");
        Source = string.Concat(Path, symbol, "_logo.png");
        Change24HColor = changePer24Hr > 0 ? Brushes.LimeGreen : Brushes.Red;
    }

    public string Symbol { get; set; }
    public string Name { get; set; }
    public string ChangePercent24Hr { get; set; }
    public string PriceUsd { get; set; }
    public string Source { get; set; }
    public Brush Change24HColor { get; set; }
}
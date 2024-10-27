namespace CryptoPlatform.Domain.Cryptos;

public class CryptosResponse
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double ChangePercent24Hr { get; set; }
    public double PriceUsd { get; set; }
}
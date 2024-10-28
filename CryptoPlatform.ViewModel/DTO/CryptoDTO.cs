namespace CryptoPlatform.ViewModel.DTO
{
    public class CryptoDTO
    {
        public CryptoDTO(string symbol, string name, double changePer24Hr, double priceUsd)
        {
            Symbol = symbol;
            Name = name;
            ChangePercent24Hr = changePer24Hr.ToString("N2");
            PriceUsd = priceUsd.ToString("N2");
        }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string ChangePercent24Hr { get; set; }
        public string PriceUsd { get; set; }
    }
}

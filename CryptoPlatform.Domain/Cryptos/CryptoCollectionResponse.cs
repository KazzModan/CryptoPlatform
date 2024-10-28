using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPlatform.Domain.Cryptos
{
    public class CryptoCollectionResponse
    {
       public IEnumerable<CryptosResponse> Data { get; set; }
    }
}

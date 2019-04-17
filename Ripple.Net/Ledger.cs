using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ripple.Net
{
    public class Ledger
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("account_hash")]
        public string AccountHash { get; set; }

        [JsonProperty("transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}

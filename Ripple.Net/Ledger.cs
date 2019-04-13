using Newtonsoft.Json;

namespace Ripple.Net
{
    public class Ledger
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("account_hash")]
        public string AccountHash { get; set; }
    }
}

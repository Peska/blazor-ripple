using Newtonsoft.Json;

namespace Ripple.Net
{
    public class Transaction
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}

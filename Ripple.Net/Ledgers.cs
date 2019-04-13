using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ripple.Net
{
    public class Ledgers
    {
        public async Task<Ledger> GetLedgerAsync(string hash)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = await client.GetAsync($"https://data.ripple.com/v2/ledgers/{hash}?transactions=true&binary=false&expand=true");

                string result = await message.Content.ReadAsStringAsync();

                LedgerResult ledgerResult = JsonConvert.DeserializeObject<LedgerResult>(result);

                if (ledgerResult.Result == "success")
                    return ledgerResult.Ledger;

                throw new LedgerException(ledgerResult.Message);
            }
        }
    }
}

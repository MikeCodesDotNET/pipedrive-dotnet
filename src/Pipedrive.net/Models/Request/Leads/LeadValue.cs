using Newtonsoft.Json;

namespace Pipedrive
{
    public class LeadValue
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; } = "USD";
    }
}

using System.Text.Json.Serialization;
using Netmavryk.Encoding;

namespace Netmavryk.Forging.Models
{
    public class TransactionContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "transaction";

        [JsonPropertyName("amount")]
        [JsonConverter(typeof(Int64StringConverter))]
        public long Amount { get; set; }

        [JsonPropertyName("destination")]
        public string Destination { get; set; } = null!;

        [JsonPropertyName("parameters")]
        public Parameters? Parameters { get; set; }
    }

    public class Parameters
    {
        [JsonPropertyName("entrypoint")]
        public string Entrypoint { get; set; } = null!;

        [JsonPropertyName("value")]
        public IMicheline Value { get; set; } = null!;
    }
}
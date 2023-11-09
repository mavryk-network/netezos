using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    [JsonConverter(typeof(OperationContentConverter))]
    public abstract class OperationContent
    {
        [JsonPropertyName("kind")]
        public abstract string Kind { get; }
    }
}

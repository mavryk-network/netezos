using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class FailingNoopContent : OperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "failing_noop";

        [JsonPropertyName("arbitrary")]
        public string Message { get; set; } = null!;
    }
}

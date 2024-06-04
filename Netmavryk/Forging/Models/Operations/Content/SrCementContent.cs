using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class SrCementContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "smart_rollup_cement";

        [JsonPropertyName("rollup")]
        public string Rollup { get; set; } = null!;
    }
}
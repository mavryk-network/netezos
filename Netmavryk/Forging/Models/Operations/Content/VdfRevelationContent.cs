using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class VdfRevelationContent : OperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "vdf_revelation";

        [JsonPropertyName("solution")]
        public List<string> Solution { get; set; } = null!;
    }
}

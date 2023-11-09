using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class SrAddMessagesContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "smart_rollup_add_messages";

        [JsonPropertyName("message")]
        [JsonConverter(typeof(HexListConverter))]
        public List<byte[]> Messages { get; set; } = null!;
    }
}
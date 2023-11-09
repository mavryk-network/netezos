using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class DelegationContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "delegation";

        [JsonPropertyName("delegate")]
        public string? Delegate { get; set; }
    }
}

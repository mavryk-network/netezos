using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class TxRollupRemoveCommitmentContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "tx_rollup_remove_commitment";

        [JsonPropertyName("rollup")]
        public string Rollup { get; set; } = null!;
    }
}

﻿using System.Text.Json.Serialization;

namespace Netmavryk.Forging.Models
{
    public class RevealContent : ManagerOperationContent
    {
        [JsonPropertyName("kind")]
        public override string Kind => "reveal";

        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; } = null!;
    }
}

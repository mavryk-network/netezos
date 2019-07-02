using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Netezos.Rpc.Queries.Post
{
    public class PreapplyBlockQuery : RpcPost
    {
        internal PreapplyBlockQuery(RpcQuery baseQuery, string append) : base(baseQuery, append)
        {
        }
        
        /// <summary>Forge a protocol data</summary>
        /// <param name="protocol">Protocol</param>
        /// <param name="priority">Priority</param>
        /// <param name="powNonce">Proof of work nonce</param>
        /// <param name="signature">Signature</param>
        /// <param name="operations">Operations</param>
        /// <param name="seedNonceHash">Seed nonce hash</param>
        /// <returns>Json response</returns>
        public async Task<JToken> PostAsync(string protocol, int priority, string powNonce, string signature, List<List<object>> operations, string seedNonceHash = null) 
            => await PostAsync(new
            {
                protocol_data = new
                {
                    protocol,
                    priority,
                    proof_of_work_nonce = powNonce,
                    seed_nonce_hash = seedNonceHash,
                    signature
                },
                operations
            });
        

        /// <summary>Forge a protocol data</summary>
        /// <param name="protocol">Protocol</param>
        /// <param name="priority">Priority</param>
        /// <param name="powNonce">Proof of work nonce</param>
        /// <param name="signature">Signature</param>
        /// <param name="operations">Operations</param>
        /// <param name="timestamp">Timestamp</param>
        /// <param name="sort">Sort</param>
        /// <param name="seedNonceHash">Seed nonce hash</param>
        /// <returns>Json response</returns>
        public async Task<JToken> PostAsync(string protocol, int priority, string powNonce, string signature, List<List<object>> operations, DateTime timestamp, bool sort = false, string seedNonceHash = null)
            => await Client.Post(
                $"{Query}?sort={sort}&timestamp={timestamp.ToEpoch()}",
                new
                {
                    protocol_data = new
                    {
                        protocol,
                        priority,
                        proof_of_work_nonce = powNonce,
                        seed_nonce_hash = seedNonceHash,
                        signature
                    },
                    operations
                }.ToJson());
    }
}
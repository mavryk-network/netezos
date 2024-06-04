using Netmavryk.Rpc.Queries;

namespace Netmavryk.Rpc
{
    /// <summary>
    /// Rpc queries builder
    /// </summary>
    public class MavrykRpc : IDisposable
    {
        /// <summary>
        /// Gets the query to the blocks
        /// </summary>
        public BlocksQuery Blocks { get; }
        
        /// <summary>
        /// Gets the query to the injection
        /// </summary>
        public InjectionQuery Inject { get; }

        string Chain { get; }
        RpcClient Client { get; }

        /// <summary>
        /// Creates the instance of MavrykRpc
        /// </summary>
        /// <param name="uri">Base URI of the node</param>
        /// <param name="chain">Chain to work with.
        /// Note: this is not a network (mainnet or testnet), but a chain of the particular network.
        /// In 99.99% cases you likely want to use Chain.Main, because Chain.Test is only relevant during the testing phase of the Mavryk voting process.</param>
        public MavrykRpc(string uri, Chain chain = Rpc.Chain.Main)
        {
            Client = new RpcClient(uri);
            Chain = chain.ToString().ToLower();

            Blocks = new BlocksQuery(Client, $"chains/{Chain}/blocks/");
            Inject = new InjectionQuery(Client, $"injection/");
        }

        /// <summary>
        /// Creates the instance of MavrykRpc
        /// </summary>
        /// <param name="uri">Base URI of the node</param>
        /// <param name="timeout">Timeout in seconds for the requests</param>
        /// <param name="chain">Chain to work with.
        /// Note: this is not a network (mainnet or testnet), but a chain of the network.
        /// In 99.99% cases you likely want to use Chain.Main, because Chain.Test is only relevant during the testing phase of the Mavryk voting process.</param>
        public MavrykRpc(string uri, int timeout, Chain chain = Rpc.Chain.Main)
        {
            Client = new RpcClient(uri, timeout);
            Chain = chain.ToString().ToLower();

            Blocks = new BlocksQuery(Client, $"chains/{Chain}/blocks/");
            Inject = new InjectionQuery(Client, $"injection/");
        }

        /// <summary>
        /// Creates the instance of MavrykRpc
        /// </summary>
        /// <param name="client">HttpClient instance that will be used for sending RPC requests.</param>
        /// <param name="chain">Chain to work with.
        /// Note: this is not a network (mainnet or testnet), but a chain of the network.
        /// In 99.99% cases you likely want to use Chain.Main, because Chain.Test is only relevant during the testing phase of the Mavryk voting process.</param>
        public MavrykRpc(HttpClient client, Chain chain = Rpc.Chain.Main)
        {
            Client = new RpcClient(client);
            Chain = chain.ToString().ToLower();

            Blocks = new BlocksQuery(Client, $"chains/{Chain}/blocks/");
            Inject = new InjectionQuery(Client, $"injection/");
        }

        /// <summary>
        /// Sends request and returns the dynamic json object
        /// </summary>
        /// <param name="query">Relative path to the RPC method</param>
        /// <returns></returns>
        public Task<dynamic> GetAsync(string query) => Client.GetJson(query);

        /// <summary>
        /// Sends request and returns the json object, deserialized to the specified type
        /// </summary>
        /// <typeparam name="T">Type of the object to deserialize to</typeparam>
        /// <param name="query">Relative path to the RPC method</param>
        /// <returns></returns>
        public Task<T?> GetAsync<T>(string query) => Client.GetJson<T>(query);

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used by the <c>MavrykRpc</c>
        /// </summary>
        public void Dispose() => Client?.Dispose();
    }
}

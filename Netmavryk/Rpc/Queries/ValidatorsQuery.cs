﻿namespace Netmavryk.Rpc.Queries
{
    /// <summary>
    /// Retrieves the delegates allowed to attest a block.
    /// </summary>
    public class ValidatorsQuery : RpcObject
    {
        internal ValidatorsQuery(RpcQuery baseQuery, string append) : base(baseQuery, append) { }

        /// <summary>
        /// Gives the attestation slots for delegates that have at least one in the next block.
        /// </summary>
        /// <returns></returns>
        public new Task<dynamic> GetAsync()
            => Client.GetJson(Query);

        /// <summary>
        /// Gives the attestation slots for the delegate
        /// </summary>
        /// <param name="baker">Delegate whose attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<dynamic> GetAsync(string baker)
            => Client.GetJson($"{Query}?delegate={baker}");

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <param name="level">Level of the block at which the attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<dynamic> GetFromLevelAsync(int level)
            => Client.GetJson($"{Query}?level={level}");

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <param name="level">Level of the block at which the attestation rights are to be returned</param>
        /// <param name="baker">Delegate whose attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<dynamic> GetFromLevelAsync(int level, string baker)
            => Client.GetJson($"{Query}?level={level}&delegate={baker}");

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <returns></returns>
        public new Task<T?> GetAsync<T>()
            => Client.GetJson<T>(Query);

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <param name="baker">Delegate whose attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<T?> GetAsync<T>(string baker)
            => Client.GetJson<T>($"{Query}?delegate={baker}");

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <param name="level">Level of the block at which the attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<T?> GetFromLevelAsync<T>(int level)
            => Client.GetJson<T>($"{Query}?level={level}");

        /// <summary>
        /// Executes the query and returns the attestation rights
        /// </summary>
        /// <param name="level">Level of the block at which the attestation rights are to be returned</param>
        /// <param name="baker">Delegate whose attestation rights are to be returned</param>
        /// <returns></returns>
        public Task<T?> GetFromLevelAsync<T>(int level, string baker)
            => Client.GetJson<T>($"{Query}?level={level}&delegate={baker}");
    }
}

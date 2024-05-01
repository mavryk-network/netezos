# Netmavryk
<a href="https://www.nuget.org/packages/Netmavryk/"><img src="https://img.shields.io/nuget/v/Netmavryk.svg" /></a>
<a href="https://www.nuget.org/packages/Netmavryk/"><img src="https://img.shields.io/nuget/dt/Netmavryk.svg" /></a>
[![License: MIT](https://img.shields.io/github/license/baking-bad/netezos.svg)](https://opensource.org/licenses/MIT)


> The first version of the library has been moved to the `v1` branch for historical purposes.

Netmavryk is a cross-platform Mavryk SDK for .NET developers, simplifying the access and interaction with the [Mavryk](https://mavryk.org/) blockchain.

The following features have been implemented so far:

| Namespace | Description | Status |
| --------- | ----------- | ------ |
| Netmavryk.Contracts | Interaction with Mavryk smart contracts | Ready to use. Dynamic wrapper: in progress... |
| Netmavryk.Forge| Forging (encoding) operation bytes | Ready to use |
| Netmavryk.Keys| Working with keys, HD keys, signing, verifying signature, etc. | Ready to use |
| Netmavryk.Ledger| Interaction with Mavryk Ledger App | Ready to use (separate package) |
| Netmavryk.Rpc | Mavryk RPC wrapper | Ready to use |

For full documentation and API Reference, please refer to the [Netmavryk website](https://netmavryk.mavryk.org/)

### Contribution

Netmavryk is an open development project so any contribution is highly appreciated, starting from documentation improvements, writing examples of usage, etc. and ending with adding new features (as long as these features do not break existing API or are only intended for one person and for very specific use case).

Do not hesitate to use [GitHub issue tracker](https://github.com/mavryk-network/netmavryk/issues) to report bugs or request features.

### Support

Feel free to join our [Discord server](https://discord.gg/aG8XKuwsQd), [Telegram chat](https://t.me/baking_bad_chat), or find us in [Mavryk Dev Slack](https://tezos-dev.slack.com/archives/CV5NX7F2L).
We will be glad to hear any feedback and feature requests and will try to help you with general use cases of the Netmavryk library.

## Getting started

Let's consider the most common use case - sending a transaction.

### Installation

`PM> Install-Package Netmavryk`

### Create private key

````cs
// generate new key
var key = new Key();

// or use existing one
var key = Key.FromBase58("edsk4ZkGeBwDyFVjZLL2neV5FUeWNN4NJntFNWmWyEBNbRwa2u3jh1");

// use this address to receive some mav
var address = key.PubKey.Address; // mv1ExNdGhoAp2BBefJs1FuiRa9UJCKYSvNjf
````

### Get some data from RPC

````cs
using var rpc = new MavrykRpc("https://rpc.mavryk.network");

// get a head block
var head = await rpc.Blocks.Head.Hash.GetAsync<string>();

// get account's counter
var counter = await rpc.Blocks.Head.Context.Contracts[address].Counter.GetAsync<int>();
````

### Forge an operation

Since our address has just been created, we need to reveal its public key before sending any operation, so that everyone can validate our signatures.
Therefore, we need to send actually two operations: a reveal and then a transaction.

Netmavryk allows you to pack multiple operations into a group and forge/send it as a single batch.

````cs
var content = new ManagerOperationContent[]
{
    new RevealContent
    {
        Source = address,
        Counter = ++counter,
        PublicKey = key.PubKey.GetBase58(),
        GasLimit = 1500,
        Fee = 1000 // 0.001 mav
    },
    new TransactionContent
    {
        Source = address,
        Counter = ++counter,
        Amount = 1000000, // 1 mav
        Destination = "mv1ExNdGhoAp2BBefJs1FuiRa9UJCKYSvNjf",
        GasLimit = 1500,
        Fee = 1000 // 0.001 mav
    }
};

var bytes = await new LocalForge().ForgeOperationGroupAsync(head, content);
````

### Sign and send

````cs
// sign the operation bytes
byte[] signature = key.SignOperation(bytes);

// inject the operation and get its id (operation hash)
var result = await rpc.Inject.Operation.PostAsync(bytes.Concat(signature));
````

That is it. We have successfully injected our first operation into the Mavryk blockchain.

## Useful links

- [Examples of Netmavryk usage](https://baking-bad.org/blog/2019/11/14/tezos-c-sdk-examples-of-netezos-usage/)
- [Forge an operation locally and sign it using Ledger](https://baking-bad.org/blog/2019/12/30/tezos-c-sdk-netezos-forge-an-operation-locally-and-sign-it-using-ledger-wallet/)

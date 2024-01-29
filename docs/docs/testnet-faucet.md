---
title: Get started
description: Short guide on how to get testnet Mavryk coins with Netmavryk, Mavryk SDK for .NET developers.
keywords: netmavryk, tezos, tezos sdk, tezos csharp, tezos csharp sdk, blockchain, blockchain sdk, faucet,
---

# Testnet Faucets interaction

To get started, we need an account with funds. The easiest way to get test XTZ or FA tokens is by using the [Faucet Telegram Bot](https://t.me/tezos_faucet_bot).

Let's generate a new key and get test coins from the [telegram bot](https://t.me/tezos_faucet_bot):

```csharp
// generate new key
var key = new Key();

// or use existing one
var key = Key.FromBase58("edsk4ZkGeBwDyFVjZLL2neV5FUeWNN4NJntFNWmWyEBNbRwa2u3jh1");

// use this address to receive some tez
var address = key.Address; // mv1ExNdGhoAp2BBefJs1FuiRa9UJCKYSvNjf
```

Let's go to the [Faucet Bot](https://t.me/tezos_faucet_bot) and get some test coins.
Click on `🤑 Get coins` to receive 100&nbsp;ꜩ to the specified mv-address, or `🍬 Get tokens` to receive some test tokens, or `➕ Add subscription` and set `Amount` to ensure your balance is always non-zero.

﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Netezos.Encoding.Serialization
{
    public class PrimTypeConverter : JsonConverter<PrimType>
    {
        internal static PrimType ParsePrim(string prim) => prim switch
        {
            "parameter" => PrimType.parameter,
            "storage" => PrimType.storage,
            "code" => PrimType.code,
            "False" => PrimType.False,
            "Elt" => PrimType.Elt,
            "Left" => PrimType.Left,
            "None" => PrimType.None,
            "Pair" => PrimType.Pair,
            "Right" => PrimType.Right,
            "Some" => PrimType.Some,
            "True" => PrimType.True,
            "Unit" => PrimType.Unit,
            "PACK" => PrimType.PACK,
            "UNPACK" => PrimType.UNPACK,
            "BLAKE2B" => PrimType.BLAKE2B,
            "SHA256" => PrimType.SHA256,
            "SHA512" => PrimType.SHA512,
            "ABS" => PrimType.ABS,
            "ADD" => PrimType.ADD,
            "AMOUNT" => PrimType.AMOUNT,
            "AND" => PrimType.AND,
            "BALANCE" => PrimType.BALANCE,
            "CAR" => PrimType.CAR,
            "CDR" => PrimType.CDR,
            "CHECK_SIGNATURE" => PrimType.CHECK_SIGNATURE,
            "COMPARE" => PrimType.COMPARE,
            "CONCAT" => PrimType.CONCAT,
            "CONS" => PrimType.CONS,
            "CREATE_ACCOUNT" => PrimType.CREATE_ACCOUNT,
            "CREATE_CONTRACT" => PrimType.CREATE_CONTRACT,
            "IMPLICIT_ACCOUNT" => PrimType.IMPLICIT_ACCOUNT,
            "DIP" => PrimType.DIP,
            "DROP" => PrimType.DROP,
            "DUP" => PrimType.DUP,
            "EDIV" => PrimType.EDIV,
            "EMPTY_MAP" => PrimType.EMPTY_MAP,
            "EMPTY_SET" => PrimType.EMPTY_SET,
            "EQ" => PrimType.EQ,
            "EXEC" => PrimType.EXEC,
            "FAILWITH" => PrimType.FAILWITH,
            "GE" => PrimType.GE,
            "GET" => PrimType.GET,
            "GT" => PrimType.GT,
            "HASH_KEY" => PrimType.HASH_KEY,
            "IF" => PrimType.IF,
            "IF_CONS" => PrimType.IF_CONS,
            "IF_LEFT" => PrimType.IF_LEFT,
            "IF_NONE" => PrimType.IF_NONE,
            "INT" => PrimType.INT,
            "LAMBDA" => PrimType.LAMBDA,
            "LE" => PrimType.LE,
            "LEFT" => PrimType.LEFT,
            "LOOP" => PrimType.LOOP,
            "LSL" => PrimType.LSL,
            "LSR" => PrimType.LSR,
            "LT" => PrimType.LT,
            "MAP" => PrimType.MAP,
            "MEM" => PrimType.MEM,
            "MUL" => PrimType.MUL,
            "NEG" => PrimType.NEG,
            "NEQ" => PrimType.NEQ,
            "NIL" => PrimType.NIL,
            "NONE" => PrimType.NONE,
            "NOT" => PrimType.NOT,
            "NOW" => PrimType.NOW,
            "OR" => PrimType.OR,
            "PAIR" => PrimType.PAIR,
            "PUSH" => PrimType.PUSH,
            "RIGHT" => PrimType.RIGHT,
            "SIZE" => PrimType.SIZE,
            "SOME" => PrimType.SOME,
            "SOURCE" => PrimType.SOURCE,
            "SENDER" => PrimType.SENDER,
            "SELF" => PrimType.SELF,
            "STEPS_TO_QUOTA" => PrimType.STEPS_TO_QUOTA,
            "SUB" => PrimType.SUB,
            "SWAP" => PrimType.SWAP,
            "TRANSFER_TOKENS" => PrimType.TRANSFER_TOKENS,
            "SET_DELEGATE" => PrimType.SET_DELEGATE,
            "UNIT" => PrimType.UNIT,
            "UPDATE" => PrimType.UPDATE,
            "XOR" => PrimType.XOR,
            "ITER" => PrimType.ITER,
            "LOOP_LEFT" => PrimType.LOOP_LEFT,
            "ADDRESS" => PrimType.ADDRESS,
            "CONTRACT" => PrimType.CONTRACT,
            "ISNAT" => PrimType.ISNAT,
            "CAST" => PrimType.CAST,
            "RENAME" => PrimType.RENAME,
            "bool" => PrimType.@bool,
            "contract" => PrimType.contract,
            "int" => PrimType.@int,
            "key" => PrimType.key,
            "key_hash" => PrimType.key_hash,
            "lambda" => PrimType.lambda,
            "list" => PrimType.list,
            "map" => PrimType.map,
            "big_map" => PrimType.big_map,
            "nat" => PrimType.nat,
            "option" => PrimType.option,
            "or" => PrimType.or,
            "pair" => PrimType.pair,
            "set" => PrimType.set,
            "signature" => PrimType.signature,
            "string" => PrimType.@string,
            "bytes" => PrimType.bytes,
            "mutez" => PrimType.mutez,
            "timestamp" => PrimType.timestamp,
            "unit" => PrimType.unit,
            "operation" => PrimType.operation,
            "address" => PrimType.address,
            "SLICE" => PrimType.SLICE,
            "DIG" => PrimType.DIG,
            "DUG" => PrimType.DUG,
            "EMPTY_BIG_MAP" => PrimType.EMPTY_BIG_MAP,
            "APPLY" => PrimType.APPLY,
            "chain_id" => PrimType.chain_id,
            "CHAIN_ID" => PrimType.CHAIN_ID,
            "LEVEL" => PrimType.LEVEL,
            "SELF_ADDRESS" => PrimType.SELF_ADDRESS,
            "never" => PrimType.never,
            "NEVER" => PrimType.NEVER,
            "UNPAIR" => PrimType.UNPAIR,
            "VOTING_POWER" => PrimType.VOTING_POWER,
            "TOTAL_VOTING_POWER" => PrimType.TOTAL_VOTING_POWER,
            "KECCAK" => PrimType.KECCAK,
            "SHA3" => PrimType.SHA3,
            "PAIRING_CHECK" => PrimType.PAIRING_CHECK,
            "bls12_381_g1" => PrimType.bls12_381_g1,
            "bls12_381_g2" => PrimType.bls12_381_g2,
            "bls12_381_fr" => PrimType.bls12_381_fr,
            "sapling_state" => PrimType.sapling_state,
            "sapling_transaction" => PrimType.sapling_transaction,
            "SAPLING_EMPTY_STATE" => PrimType.SAPLING_EMPTY_STATE,
            "SAPLING_VERIFY_UPDATE" => PrimType.SAPLING_VERIFY_UPDATE,
            "ticket" => PrimType.ticket,
            "TICKET" => PrimType.TICKET,
            "READ_TICKET" => PrimType.READ_TICKET,
            "SPLIT_TICKET" => PrimType.SPLIT_TICKET,
            "JOIN_TICKETS" => PrimType.JOIN_TICKETS,
            "GET_AND_UPDATE" => PrimType.GET_AND_UPDATE,
            "chest" => PrimType.chest,
            "chest_key" => PrimType.chest_key,
            "OPEN_CHEST" => PrimType.OPEN_CHEST,
            "VIEW" => PrimType.VIEW,
            "view" => PrimType.view,
            "constant" => PrimType.constant,
            var value => throw new FormatException($"Invalid prim: {value}")
        };

        public override PrimType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ParsePrim(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, PrimType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: oracle_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Oracle {

  #region Events
  internal partial class QueryCreated : aelf::IEvent<QueryCreated>
  {
    public global::System.Collections.Generic.IEnumerable<QueryCreated> GetIndexed()
    {
      return new List<QueryCreated>
      {
      };
    }

    public QueryCreated GetNonIndexed()
    {
      return new QueryCreated
      {
        Payment = Payment,
        CallbackInfo = CallbackInfo,
        AggregatorContractAddress = AggregatorContractAddress,
        DesignatedNodeList = DesignatedNodeList,
        QueryInfo = QueryInfo,
        AggregateThreshold = AggregateThreshold,
        QuerySender = QuerySender,
        QueryId = QueryId,
        Token = Token,
        MaximumPermissibleDeviation = MaximumPermissibleDeviation,
        AggregateOption = AggregateOption,
        TaskId = TaskId,
      };
    }
  }

  internal partial class QueryTaskCreated : aelf::IEvent<QueryTaskCreated>
  {
    public global::System.Collections.Generic.IEnumerable<QueryTaskCreated> GetIndexed()
    {
      return new List<QueryTaskCreated>
      {
      };
    }

    public QueryTaskCreated GetNonIndexed()
    {
      return new QueryTaskCreated
      {
        EachPayment = EachPayment,
        SupposedQueryTimes = SupposedQueryTimes,
        QueryInfo = QueryInfo,
        EndTime = EndTime,
        DesignatedNodeList = DesignatedNodeList,
        AggregatorContractAddress = AggregatorContractAddress,
        CallbackInfo = CallbackInfo,
        Creator = Creator,
        AggregateThreshold = AggregateThreshold,
        AggregateOption = AggregateOption,
      };
    }
  }

  internal partial class QueryCancelled : aelf::IEvent<QueryCancelled>
  {
    public global::System.Collections.Generic.IEnumerable<QueryCancelled> GetIndexed()
    {
      return new List<QueryCancelled>
      {
      };
    }

    public QueryCancelled GetNonIndexed()
    {
      return new QueryCancelled
      {
        QueryId = QueryId,
      };
    }
  }

  internal partial class SufficientCommitmentsCollected : aelf::IEvent<SufficientCommitmentsCollected>
  {
    public global::System.Collections.Generic.IEnumerable<SufficientCommitmentsCollected> GetIndexed()
    {
      return new List<SufficientCommitmentsCollected>
      {
      };
    }

    public SufficientCommitmentsCollected GetNonIndexed()
    {
      return new SufficientCommitmentsCollected
      {
        QueryId = QueryId,
      };
    }
  }

  internal partial class Committed : aelf::IEvent<Committed>
  {
    public global::System.Collections.Generic.IEnumerable<Committed> GetIndexed()
    {
      return new List<Committed>
      {
      };
    }

    public Committed GetNonIndexed()
    {
      return new Committed
      {
        QueryId = QueryId,
        OracleNodeAddress = OracleNodeAddress,
        Commitment = Commitment,
      };
    }
  }

  internal partial class CommitmentRevealed : aelf::IEvent<CommitmentRevealed>
  {
    public global::System.Collections.Generic.IEnumerable<CommitmentRevealed> GetIndexed()
    {
      return new List<CommitmentRevealed>
      {
      };
    }

    public CommitmentRevealed GetNonIndexed()
    {
      return new CommitmentRevealed
      {
        QueryId = QueryId,
        OracleNodeAddress = OracleNodeAddress,
        Commitment = Commitment,
        RevealData = RevealData,
        Salt = Salt,
      };
    }
  }

  internal partial class CommitmentRevealFailed : aelf::IEvent<CommitmentRevealFailed>
  {
    public global::System.Collections.Generic.IEnumerable<CommitmentRevealFailed> GetIndexed()
    {
      return new List<CommitmentRevealFailed>
      {
      };
    }

    public CommitmentRevealFailed GetNonIndexed()
    {
      return new CommitmentRevealFailed
      {
        QueryId = QueryId,
        OracleNodeAddress = OracleNodeAddress,
        Commitment = Commitment,
        RevealData = RevealData,
        Salt = Salt,
      };
    }
  }

  internal partial class QueryCompletedWithAggregation : aelf::IEvent<QueryCompletedWithAggregation>
  {
    public global::System.Collections.Generic.IEnumerable<QueryCompletedWithAggregation> GetIndexed()
    {
      return new List<QueryCompletedWithAggregation>
      {
      };
    }

    public QueryCompletedWithAggregation GetNonIndexed()
    {
      return new QueryCompletedWithAggregation
      {
        QueryId = QueryId,
        Result = Result,
      };
    }
  }

  internal partial class QueryCompletedWithoutAggregation : aelf::IEvent<QueryCompletedWithoutAggregation>
  {
    public global::System.Collections.Generic.IEnumerable<QueryCompletedWithoutAggregation> GetIndexed()
    {
      return new List<QueryCompletedWithoutAggregation>
      {
      };
    }

    public QueryCompletedWithoutAggregation GetNonIndexed()
    {
      return new QueryCompletedWithoutAggregation
      {
        QueryId = QueryId,
        Result = Result,
      };
    }
  }

  internal partial class TokenLocked : aelf::IEvent<TokenLocked>
  {
    public global::System.Collections.Generic.IEnumerable<TokenLocked> GetIndexed()
    {
      return new List<TokenLocked>
      {
      };
    }

    public TokenLocked GetNonIndexed()
    {
      return new TokenLocked
      {
        OracleNodeAddress = OracleNodeAddress,
        FromAddress = FromAddress,
        LockedAmount = LockedAmount,
      };
    }
  }

  #endregion
  internal static partial class OracleContractContainer
  {
    static readonly string __ServiceName = "OracleContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.InitializeInput> __Marshaller_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.QueryInput> __Marshaller_QueryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.QueryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.CommitInput> __Marshaller_CommitInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.CommitInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.RevealInput> __Marshaller_RevealInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.RevealInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.CreateQueryTaskInput> __Marshaller_CreateQueryTaskInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.CreateQueryTaskInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.TaskQueryInput> __Marshaller_TaskQueryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.TaskQueryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.CompleteQueryTaskInput> __Marshaller_CompleteQueryTaskInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.CompleteQueryTaskInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.CreateRegimentInput> __Marshaller_CreateRegimentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.CreateRegimentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.JoinRegimentInput> __Marshaller_JoinRegimentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.JoinRegimentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.LeaveRegimentInput> __Marshaller_LeaveRegimentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.LeaveRegimentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.AddRegimentMemberInput> __Marshaller_AddRegimentMemberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.AddRegimentMemberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.DeleteRegimentMemberInput> __Marshaller_DeleteRegimentMemberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.DeleteRegimentMemberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.TransferRegimentOwnershipInput> __Marshaller_TransferRegimentOwnershipInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.TransferRegimentOwnershipInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.AddAdminsInput> __Marshaller_AddAdminsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.AddAdminsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.DeleteAdminsInput> __Marshaller_DeleteAdminsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.DeleteAdminsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.LockTokensInput> __Marshaller_LockTokensInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.LockTokensInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.UnlockTokensInput> __Marshaller_UnlockTokensInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.UnlockTokensInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.OracleNodeThreshold> __Marshaller_OracleNodeThreshold = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.OracleNodeThreshold.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.QueryRecord> __Marshaller_QueryRecord = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.QueryRecord.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.CommitmentMap> __Marshaller_CommitmentMap = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.CommitmentMap.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.AddressList> __Marshaller_AddressList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.AddressList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Oracle.QueryTask> __Marshaller_QueryTask = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Oracle.QueryTask.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_InitializeAndCreateToken = new aelf::Method<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "InitializeAndCreateToken",
        __Marshaller_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.QueryInput, global::AElf.Types.Hash> __Method_Query = new aelf::Method<global::AElf.Contracts.Oracle.QueryInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "Query",
        __Marshaller_QueryInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.CommitInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Commit = new aelf::Method<global::AElf.Contracts.Oracle.CommitInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Commit",
        __Marshaller_CommitInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.RevealInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Reveal = new aelf::Method<global::AElf.Contracts.Oracle.RevealInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Reveal",
        __Marshaller_RevealInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CancelQuery = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CancelQuery",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.CreateQueryTaskInput, global::AElf.Types.Hash> __Method_CreateQueryTask = new aelf::Method<global::AElf.Contracts.Oracle.CreateQueryTaskInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateQueryTask",
        __Marshaller_CreateQueryTaskInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.TaskQueryInput, global::AElf.Types.Hash> __Method_TaskQuery = new aelf::Method<global::AElf.Contracts.Oracle.TaskQueryInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "TaskQuery",
        __Marshaller_TaskQueryInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.CompleteQueryTaskInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CompleteQueryTask = new aelf::Method<global::AElf.Contracts.Oracle.CompleteQueryTaskInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CompleteQueryTask",
        __Marshaller_CompleteQueryTaskInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeController = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeController",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.CreateRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateRegiment = new aelf::Method<global::AElf.Contracts.Oracle.CreateRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateRegiment",
        __Marshaller_CreateRegimentInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.JoinRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_JoinRegiment = new aelf::Method<global::AElf.Contracts.Oracle.JoinRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "JoinRegiment",
        __Marshaller_JoinRegimentInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.LeaveRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_LeaveRegiment = new aelf::Method<global::AElf.Contracts.Oracle.LeaveRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "LeaveRegiment",
        __Marshaller_LeaveRegimentInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.AddRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddRegimentMember = new aelf::Method<global::AElf.Contracts.Oracle.AddRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddRegimentMember",
        __Marshaller_AddRegimentMemberInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.DeleteRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteRegimentMember = new aelf::Method<global::AElf.Contracts.Oracle.DeleteRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeleteRegimentMember",
        __Marshaller_DeleteRegimentMemberInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.TransferRegimentOwnershipInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_TransferRegimentOwnership = new aelf::Method<global::AElf.Contracts.Oracle.TransferRegimentOwnershipInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "TransferRegimentOwnership",
        __Marshaller_TransferRegimentOwnershipInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.AddAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddAdmins = new aelf::Method<global::AElf.Contracts.Oracle.AddAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddAdmins",
        __Marshaller_AddAdminsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.DeleteAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAdmins = new aelf::Method<global::AElf.Contracts.Oracle.DeleteAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeleteAdmins",
        __Marshaller_DeleteAdminsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.LockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_LockTokens = new aelf::Method<global::AElf.Contracts.Oracle.LockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "LockTokens",
        __Marshaller_LockTokensInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.UnlockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UnlockTokens = new aelf::Method<global::AElf.Contracts.Oracle.UnlockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UnlockTokens",
        __Marshaller_UnlockTokensInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Oracle.OracleNodeThreshold, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetThreshold = new aelf::Method<global::AElf.Contracts.Oracle.OracleNodeThreshold, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetThreshold",
        __Marshaller_OracleNodeThreshold,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeDefaultExpirationSeconds = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeDefaultExpirationSeconds",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_EnableChargeFee = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "EnableChargeFee",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddPostPayAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddPostPayAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemovePostPayAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemovePostPayAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> __Method_GetController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryRecord> __Method_GetQueryRecord = new aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryRecord>(
        aelf::MethodType.View,
        __ServiceName,
        "GetQueryRecord",
        __Marshaller_aelf_Hash,
        __Marshaller_QueryRecord);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.CommitmentMap> __Method_GetCommitmentMap = new aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.CommitmentMap>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCommitmentMap",
        __Marshaller_aelf_Hash,
        __Marshaller_CommitmentMap);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_GetOracleTokenSymbol = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetOracleTokenSymbol",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetLockedTokensAmount = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetLockedTokensAmount",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Oracle.OracleNodeThreshold> __Method_GetThreshold = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Oracle.OracleNodeThreshold>(
        aelf::MethodType.View,
        __ServiceName,
        "GetThreshold",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_OracleNodeThreshold);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetDefaultExpirationSeconds = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDefaultExpirationSeconds",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.AddressList> __Method_GetHelpfulNodeList = new aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.AddressList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetHelpfulNodeList",
        __Marshaller_aelf_Hash,
        __Marshaller_AddressList);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryTask> __Method_GetQueryTask = new aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryTask>(
        aelf::MethodType.View,
        __ServiceName,
        "GetQueryTask",
        __Marshaller_aelf_Hash,
        __Marshaller_QueryTask);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Oracle.AddressList> __Method_GetRegimentMemberList = new aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Oracle.AddressList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetRegimentMemberList",
        __Marshaller_aelf_Address,
        __Marshaller_AddressList);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Oracle.OracleContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Oracle.OracleContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class OracleContractReferenceState : global::AElf.Sdk.CSharp.State.ContractReferenceState
    {
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> Initialize { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> InitializeAndCreateToken { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.QueryInput, global::AElf.Types.Hash> Query { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.CommitInput, global::Google.Protobuf.WellKnownTypes.Empty> Commit { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.RevealInput, global::Google.Protobuf.WellKnownTypes.Empty> Reveal { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> CancelQuery { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.CreateQueryTaskInput, global::AElf.Types.Hash> CreateQueryTask { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.TaskQueryInput, global::AElf.Types.Hash> TaskQuery { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.CompleteQueryTaskInput, global::Google.Protobuf.WellKnownTypes.Empty> CompleteQueryTask { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> ChangeController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.CreateRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> CreateRegiment { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.JoinRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> JoinRegiment { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.LeaveRegimentInput, global::Google.Protobuf.WellKnownTypes.Empty> LeaveRegiment { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.AddRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> AddRegimentMember { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.DeleteRegimentMemberInput, global::Google.Protobuf.WellKnownTypes.Empty> DeleteRegimentMember { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.TransferRegimentOwnershipInput, global::Google.Protobuf.WellKnownTypes.Empty> TransferRegimentOwnership { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.AddAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty> AddAdmins { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.DeleteAdminsInput, global::Google.Protobuf.WellKnownTypes.Empty> DeleteAdmins { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.LockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty> LockTokens { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.UnlockTokensInput, global::Google.Protobuf.WellKnownTypes.Empty> UnlockTokens { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Contracts.Oracle.OracleNodeThreshold, global::Google.Protobuf.WellKnownTypes.Empty> SetThreshold { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> ChangeDefaultExpirationSeconds { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> EnableChargeFee { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> AddPostPayAddress { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> RemovePostPayAddress { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> GetController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryRecord> GetQueryRecord { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.CommitmentMap> GetCommitmentMap { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> GetOracleTokenSymbol { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Int64Value> GetLockedTokensAmount { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Oracle.OracleNodeThreshold> GetThreshold { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> GetDefaultExpirationSeconds { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.AddressList> GetHelpfulNodeList { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Contracts.Oracle.QueryTask> GetQueryTask { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::AElf.Contracts.Oracle.AddressList> GetRegimentMemberList { get; set; }
    }
  }
}
#endregion


using AElf.CSharp.Core;
using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;
using MTRecorder;

namespace AElf.Contracts.MerkleTreeRecorder
{
    public partial class MerkleTreeRecorderContract : MerkleTreeRecorderContractContainer.MerkleTreeRecorderContractBase
    {
        public override Empty Initialize(Empty input)
        {
            AssertSenderIsOwner(null, "Already initialized.");
            State.Owner.Value = Context.Sender;
            return new Empty();
        }

        public override Empty ChangeOwner(Address input)
        {
            AssertSenderIsOwner(Context.Sender);
            State.Owner.Value = input;
            return new Empty();
        }

        public override Empty CreateRecorder(Recorder input)
        {
            AssertSenderIsOwner(Context.Sender);
            State.Recorder[State.MerkleTreeRecorderCount.Value] = input;
            State.LastRecordedLeafIndex[State.MerkleTreeRecorderCount.Value] = -1;
            Context.Fire(new RecorderCreated
            {
                Admin = input.Admin,
                MaximalLeafCount = input.MaximalLeafCount,
                RecorderId = State.MerkleTreeRecorderCount.Value
            });

            State.MerkleTreeRecorderCount.Value = State.MerkleTreeRecorderCount.Value.Add(1);
            return new Empty();
        }

        public override Empty RecordMerkleTree(RecordMerkleTreeInput input)
        {
            var recorder = State.Recorder[input.RecorderId];
            if (recorder == null) throw new AssertionException("Recorder not found.");
            Assert(recorder.Admin == Context.Sender, "Not admin.");
            var lastRecordedLeafIndex = State.LastRecordedLeafIndex[input.RecorderId];
            Assert(input.LastLeafIndex > lastRecordedLeafIndex, "It is not a new tree.");
            Assert(input.LastLeafIndex.Sub(lastRecordedLeafIndex) <= recorder.MaximalLeafCount,
                "Satisfied MerkleTree absent.");

            var satisfiedMerkleTreeCount = State.SatisfiedMerkleTreeCount[input.RecorderId];
            var newRecordedLeafLocated = input.LastLeafIndex.Div(recorder.MaximalLeafCount);
            if (newRecordedLeafLocated > satisfiedMerkleTreeCount)
                Assert(lastRecordedLeafIndex ==
                       satisfiedMerkleTreeCount.Add(1).Mul(recorder.MaximalLeafCount).Sub(1),
                    $"Unable to record the tree with {input.LastLeafIndex}");

            var merkleTree = new MerkleTree
            {
                MerkleTreeRoot = input.MerkleTreeRoot,
                LastLeafIndex = input.LastLeafIndex,
                FirstLeafIndex = State.SatisfiedMerkleTreeCount[input.RecorderId].Mul(recorder.MaximalLeafCount),
            };

            if (input.LastLeafIndex == recorder.MaximalLeafCount
                    .Mul(State.SatisfiedMerkleTreeCount[input.RecorderId].Add(1)).Sub(1))
            {
                // new satisfied merkle tree
                State.SatisfiedMerkleTrees[input.RecorderId][State.SatisfiedMerkleTreeCount[input.RecorderId]] =
                    merkleTree;

                State.SatisfiedMerkleTreeCount[input.RecorderId] =
                    State.SatisfiedMerkleTreeCount[input.RecorderId].Add(1);
            }
            else
            {
                // new un-satisfied merkle tree
                State.UnSatisfiedMerkleTrees[input.RecorderId][input.LastLeafIndex % recorder.MaximalLeafCount] =
                    merkleTree;
            }

            State.LastRecordedLeafIndex[input.RecorderId] = input.LastLeafIndex;
            Context.Fire(new MerkleTreeRecorded
            {
                LastLeafIndex = input.LastLeafIndex,
                RecorderId = input.RecorderId
            });

            return new Empty();
        }

        private void AssertSenderIsOwner(Address address, string message = null)
        {
            Assert(State.Owner.Value == address, message ?? "No permission.");
        }
    }
}
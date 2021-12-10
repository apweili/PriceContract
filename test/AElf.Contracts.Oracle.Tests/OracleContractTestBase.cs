using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AElf.Boilerplate.TestBase;
using AElf.Contracts.Association;
using AElf.Contracts.IntegerAggregator;
using AElf.Contracts.MultiToken;
using AElf.Contracts.Parliament;
using AElf.Contracts.Report;
using AElf.Contracts.OracleUser;
using AElf.Contracts.Regiment;
using AElf.ContractTestKit;
using AElf.Cryptography.ECDSA;
using AElf.Standards.ACS3;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.Oracle
{
    public class OracleContractTestBase : DAppContractTestBase<OracleContractTestModule>
    {
        protected Address DefaultSender { get; set; }
        internal IList<OracleContractContainer.OracleContractStub> OracleNodes { get; set; }
        internal OracleContractContainer.OracleContractStub OracleContractStub { get; set; }
        internal TokenContractContainer.TokenContractStub TokenContractStub { get; set; }
        internal ParliamentContractImplContainer.ParliamentContractImplStub ParliamentContractStub { get; set; }
        internal AssociationContractContainer.AssociationContractStub AssociationContractStub { get; set; }
        internal OracleUserContractContainer.OracleUserContractStub OracleUserContractStub { get; set; }
        internal ReportContractContainer.ReportContractStub ReportContractStub { get; set; }

        internal IntegerAggregatorContractContainer.IntegerAggregatorContractStub IntegerAggregatorContractStub
        {
            get;
            set;
        }

        internal RegimentContractContainer.RegimentContractStub RegimentContractStub { get; set; }

        protected Address OracleUserContractAddress =>
            SystemContractAddresses[OracleUserSmartContractAddressNameProvider.Name];

        protected Address ReportContractAddress =>
            SystemContractAddresses[ReportSmartContractAddressNameProvider.Name];

        protected Address IntegerAggregatorContractAddress =>
            SystemContractAddresses[NumericAggregatorSmartContractAddressNameProvider.Name];

        protected Address RegimentContractAddress =>
            SystemContractAddresses[RegimentSmartContractAddressNameProvider.Name];

        protected OracleContractTestBase()
        {
            var keyPair = SampleAccount.Accounts.First().KeyPair;
            DefaultSender = SampleAccount.Accounts.First().Address;
            OracleContractStub = GetOracleContractStub(keyPair);
            TokenContractStub = GetTokenContractStub(keyPair);
            ParliamentContractStub = GetParliamentContractStub(keyPair);
            OracleUserContractStub = GetOracleUserContractStub(keyPair);
            AssociationContractStub = GetAssociationContractStub(keyPair);
            ReportContractStub = GetReportContractStub(keyPair);
            IntegerAggregatorContractStub = GetIntegerAggregatorContractStub(keyPair);
            RegimentContractStub = GetRegimentContractStub(keyPair);
            OracleNodes = new List<OracleContractContainer.OracleContractStub>();
        }

        internal OracleContractContainer.OracleContractStub GetOracleContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<OracleContractContainer.OracleContractStub>(DAppContractAddress, senderKeyPair);
        }

        internal TokenContractContainer.TokenContractStub GetTokenContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<TokenContractContainer.TokenContractStub>(TokenContractAddress, senderKeyPair);
        }

        internal ParliamentContractImplContainer.ParliamentContractImplStub GetParliamentContractStub(
            ECKeyPair senderKeyPair)
        {
            return GetTester<ParliamentContractImplContainer.ParliamentContractImplStub>(ParliamentContractAddress,
                senderKeyPair);
        }

        internal AssociationContractContainer.AssociationContractStub GetAssociationContractStub(
            ECKeyPair senderKeyPair)
        {
            return GetTester<AssociationContractContainer.AssociationContractStub>(AssociationContractAddress,
                senderKeyPair);
        }

        internal ReportContractContainer.ReportContractStub GetReportContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<ReportContractContainer.ReportContractStub>(ReportContractAddress,
                senderKeyPair);
        }

        internal IntegerAggregatorContractContainer.IntegerAggregatorContractStub GetIntegerAggregatorContractStub(
            ECKeyPair senderKeyPair)
        {
            return GetTester<IntegerAggregatorContractContainer.IntegerAggregatorContractStub>(
                IntegerAggregatorContractAddress, senderKeyPair);
        }

        internal OracleUserContractContainer.OracleUserContractStub GetOracleUserContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<OracleUserContractContainer.OracleUserContractStub>(OracleUserContractAddress,
                senderKeyPair);
        }

        internal RegimentContractContainer.RegimentContractStub GetRegimentContractStub(
            ECKeyPair senderKeyPair)
        {
            return GetTester<RegimentContractContainer.RegimentContractStub>(
                RegimentContractAddress, senderKeyPair);
        }

        protected IEnumerable<Account> GetNodes(int count)
        {
            return SampleAccount.Accounts.Skip(1).Take(count).ToList();
        }

        protected async Task<Address> GetDefaultParliament()
        {
            return await ParliamentContractStub.GetDefaultOrganizationAddress.CallAsync(new Empty());
        }

        internal async Task ParliamentProposeAndRelease(CreateProposalInput proposal)
        {
            var ret = await ParliamentContractStub.CreateProposal.SendAsync(proposal);
            var proposalId = Hash.Parser.ParseFrom(ret.TransactionResult.ReturnValue);
            await ParliamentContractStub.Approve.SendAsync(proposalId);
            await ParliamentContractStub.Release.SendAsync(proposalId);
        }
    }
}
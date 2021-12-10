using System.Collections.Generic;
using System.IO;
using AElf.Boilerplate.TestBase;
using AElf.Contracts.Bridge;
using AElf.Contracts.NumericAggregator;
using AElf.Contracts.OracleUser;
using AElf.Contracts.Regiment;
using AElf.Contracts.Report;
using AElf.ContractTestBase;
using AElf.Kernel.SmartContract.Application;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace AElf.Contracts.Oracle
{
    [DependsOn(typeof(MainChainDAppContractTestModule))]
    public class OracleContractTestModule : MainChainDAppContractTestModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<IContractInitializationProvider, OracleContractInitializationProvider>();
            context.Services.AddSingleton<IContractInitializationProvider, OracleUserContractInitializationProvider>();
            context.Services
                .AddSingleton<IContractInitializationProvider, NumericAggregatorContractInitializationProvider>();
            context.Services.AddSingleton<IContractInitializationProvider, ReportContractInitializationProvider>();
            context.Services.AddSingleton<IContractInitializationProvider, RegimentContractInitializationProvider>();
        }

        public override void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {
            var contractCodeProvider = context.ServiceProvider.GetService<IContractCodeProvider>();
            var contractCodes = new Dictionary<string, byte[]>(contractCodeProvider.Codes)
            {
                {
                    new OracleContractInitializationProvider().ContractCodeName,
                    File.ReadAllBytes(typeof(OracleContract).Assembly.Location)
                },
                {
                    new OracleUserContractInitializationProvider().ContractCodeName,
                    File.ReadAllBytes(typeof(OracleUserContract).Assembly.Location)
                },
                {
                    new NumericAggregatorContractInitializationProvider().ContractCodeName,
                    File.ReadAllBytes(typeof(NumericAggregatorContract).Assembly.Location)
                },
                {
                    new ReportContractInitializationProvider().ContractCodeName,
                    File.ReadAllBytes(typeof(ReportContract).Assembly.Location)
                },

                {
                    new RegimentContractInitializationProvider().ContractCodeName,
                    File.ReadAllBytes(typeof(RegimentContract).Assembly.Location)
                }
            };
            contractCodeProvider.Codes = contractCodes;
        }
    }
}
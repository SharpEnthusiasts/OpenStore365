using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using OpenStore365.Serverless.Auth.AAD_B2C.IoC;

[assembly: FunctionsStartup(typeof(OpenStore365.Samples.Serverless.Auth.Startup))]

namespace OpenStore365.Samples.Serverless.Auth
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder) =>
            builder.Services.Add_AAD_B2C_HttpHeaderUserProvider();
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace OpenStore365.Serverless.Auth.AAD_B2C.IoC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection Add_AAD_B2C_HttpHeaderUserProvider(this IServiceCollection services) =>
            services.AddSingleton<IUserProvider, HttpHeaderUserProvider>();
    }
}

using Microsoft.AspNetCore.Http;

namespace OpenStore365.Serverless.Auth
{
    public interface IUserProvider
    {
        User GetUser(HttpRequest httpRequest);
    }
}

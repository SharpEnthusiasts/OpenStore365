using Microsoft.AspNetCore.Http;
using OpenStore365.Serverless.Auth.AAD_B2C.Constants;
using System;

namespace OpenStore365.Serverless.Auth.AAD_B2C
{
    public class HttpHeaderUserProvider : IUserProvider
    {
        public User GetUser(HttpRequest httpRequest) =>
            new User(
                ExtractUserId(httpRequest),
                TryExtractDisplayName(httpRequest));

        private string ExtractUserId(HttpRequest httpRequest)
        {
            if (!httpRequest.Headers.TryGetValue(EasyAuth.HttpHeaders.ID, out var id))
            {
                throw new Exception($"User ID must be present in the '{EasyAuth.HttpHeaders.ID}' HTTP header.");
            }

            if (!Guid.TryParse(id, out var _))
            {
                throw new Exception("User ID has to follow the GUID format.");
            }

            return id;
        }

        private string TryExtractDisplayName(HttpRequest httpRequest)
        {
            httpRequest.Headers.TryGetValue(EasyAuth.HttpHeaders.DISPLAY_NAME, out var displayName);
            return displayName;
        }
    }
}

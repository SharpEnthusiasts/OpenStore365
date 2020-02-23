using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using OpenStore365.Serverless;
using OpenStore365.Serverless.Auth;

namespace OpenStore365.Samples.Serverless.Auth.Functions
{
    public class GetUser
    {
        private readonly IUserProvider _userProvider;

        public GetUser(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }

        [FunctionName(nameof(GetUser))]
        public IActionResult Execute(
            [HttpTrigger(AuthorizationLevel.Anonymous, HTTP.GET, Route = "Users/Me")] HttpRequest httpRequest) =>
                new OkObjectResult(_userProvider.GetUser(httpRequest));
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using OpenStore365.Serverless;
using System.Linq;

namespace OpenStore365.Samples.Serverless.Auth.Functions
{
    public static class GetUserClaimHttpHeaders
    {
        [FunctionName(nameof(GetUserClaimHttpHeaders))]
        public static IActionResult Execute(
            [HttpTrigger(AuthorizationLevel.Anonymous, HTTP.GET, Route = "Http/Headers/UserClaims")] HttpRequest request) =>
                new OkObjectResult(request.Headers
                    .Where(x => x.Key.StartsWith("X-MS-CLIENT"))
                    .ToList());
    }
}

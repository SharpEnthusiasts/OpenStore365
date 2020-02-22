using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using OpenStore365.Serverless;

namespace OpenStore365.Samples.Serverless.Auth.Functions
{
    public static class GetHttpHeaders
    {
        [FunctionName(nameof(GetHttpHeaders))]
        public static IActionResult Execute(
            [HttpTrigger(AuthorizationLevel.Anonymous, HTTP.GET, Route = "Http/Headers")] HttpRequest request) =>
                new OkObjectResult(request.Headers);
    }
}

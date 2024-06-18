using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class GetResumeCounter
    {
        private readonly ILogger<GetResumeCounter> _logger;

        public GetResumeCounter(ILogger<GetResumeCounter> logger)
        {
            _logger = logger;
        }

        [Function("GetResumeCounter")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req,
        [CosmosDBInput(databaseName: "AzureResume", containerName: "Counter", Connection = "AzureResumeConnectionString", Id = "1", PartitionKey = "id")] Counter counter)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

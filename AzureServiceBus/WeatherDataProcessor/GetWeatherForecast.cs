using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace WeatherDataProcessor
{
    public class GetWeatherForecast
    {
        [FunctionName("GetWeatherForecast")]
        public void Run([ServiceBusTrigger("add-weather-data", Connection = "connectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}

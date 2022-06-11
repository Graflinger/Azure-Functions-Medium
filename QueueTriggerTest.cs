using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class QueueTriggerTest
    {
        [FunctionName("QueueTriggerTest")]
        [return: Queue("test-output", Connection = "StorageConnectionAppSetting")]
        public static string Run([QueueTrigger("test-queue", Connection = "functionkafkatrigger2022_STORAGE")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            return myQueueItem;
        }
    }
}

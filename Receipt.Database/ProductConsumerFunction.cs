using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Receipt.Database.Models;
using System.Text.Json;

namespace Receipt.Database
{
    public class ProductConsumerFunction
    {
        private readonly ILogger<ProductConsumerFunction> _logger;

        public ProductConsumerFunction(ILogger<ProductConsumerFunction> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ProductConsumerFunction))]

        public async Task Run(
            [ServiceBusTrigger(topicName: "TopicName", "Subscription", Connection = "ServiceBusConnectionString")]
                    ServiceBusReceivedMessage message,
            ServiceBusMessageActions messageActions)
        {
            var product = JsonSerializer.Deserialize<Product>(message.Body);

            _logger.LogInformation("Product received: {Product}", product);

            if (product is not null)
            {
                var _ = new ProductDb { Product = product };
            }

            await messageActions.CompleteMessageAsync(message);
        }
    }
}

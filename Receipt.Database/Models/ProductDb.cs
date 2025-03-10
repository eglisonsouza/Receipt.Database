using Microsoft.Azure.Functions.Worker;

namespace Receipt.Database.Models
{
    public class ProductDb
    {
        [CosmosDBOutput("%DatabaseName%", "%ContainerName%", Connection = "CosmoDbConnection", CreateIfNotExists = true, PartitionKey = "Id")]
        public required Product Product { get; set; }
    }
}

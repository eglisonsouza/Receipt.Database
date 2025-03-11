# Receipt.Database

This project contains the implementation of a product receipt system using Azure Functions and Cosmos DB. The main components are the `Product` model, the `ProductDb` model, and the `ProductConsumerFunction`.

## Project Structure

### Models

#### Product

The `Product` class represents the product entity with the following properties:

#### ProductDb

The `ProductDb` class is used to interact with Cosmos DB. It contains a `Product` property and is decorated with the `CosmosDBOutput` attribute to specify the database and container details.

### Functions

#### ProductConsumerFunction

The `ProductConsumerFunction` class is an Azure Function that listens to a Service Bus topic for incoming product messages. It deserializes the message into a `Product` object and logs the received product. If the product is not null, it creates a new `ProductDb` instance.

## Requirements

- .NET 8
- Azure Functions
- Azure Service Bus
- Azure Cosmos DB

## Configuration

Ensure the following settings are configured in your application settings:

- `ServiceBusConnectionString`: Connection string for Azure Service Bus.
- `CosmoDbConnection`: Connection string for Azure Cosmos DB.
- `DatabaseName`: Name of the Cosmos DB database.
- `ContainerName`: Name of the Cosmos DB container.

## Running the Project

1. Clone the repository.
2. Configure the required settings.
3. Build and run the project using Visual Studio 2022 or the .NET CLI.

## License

This project is licensed under the MIT License.

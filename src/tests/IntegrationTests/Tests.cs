namespace BlockadeLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BlockadeLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BLOCKADELABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BLOCKADELABS_API_KEY environment variable is not found.");

        var client = new BlockadeLabsClient(apiKey);
        
        return client;
    }
}

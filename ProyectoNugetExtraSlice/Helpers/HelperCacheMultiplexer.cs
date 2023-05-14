using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using StackExchange.Redis;

namespace MVCApiExtraSlice.Helpers
{
    public static class HelperCacheMultiplexer
    {
        
        private static Lazy<ConnectionMultiplexer> CreateConnection =
        new Lazy<ConnectionMultiplexer>(() =>
        {
            var client = new SecretClient(new Uri("https://keyvaultextraslice.vault.azure.net/"), new DefaultAzureCredential());
            KeyVaultSecret secret = client.GetSecret("cacheredis");
            string cnn = secret.Value;
            return ConnectionMultiplexer.Connect(cnn);
        });

        public static ConnectionMultiplexer GetConnection
        {
            get{
                return CreateConnection.Value;
            }
        }

    }
}

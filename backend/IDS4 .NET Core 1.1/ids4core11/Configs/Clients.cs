using IdentityServer4.Models;
using System.Collections.Generic;

namespace ids4core11.Configs
{
    public class Clients
    {
        // client want to access resources (aka scopes)
        public static IEnumerable<Client> GetAll()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "bgmvc",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("bgmvcsecret".Sha256()) },
                    AllowedScopes = { "scope.bgmvc" }
                },
                new Client
                {
                    ClientId = "bgapi",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("bgapisecret".Sha256()) },
                    AllowedScopes = { "scope.bgapi" }
                },
                // Just for a demo
                new Client
                {
                    ClientId = "ClientIdThatCanOnlyRead",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret1".Sha256()) },
                    AllowedScopes = { "scope.readaccess" }
                },
                new Client
                {
                    ClientId = "ClientIdWithFullAccess",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret2".Sha256()) },
                    AllowedScopes = { "scope.fullaccess" }
                }
            };
        }
    }
}

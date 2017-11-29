using IdentityServer4.Models;
using System.Collections.Generic;

namespace ids4core11.Configs
{
    public class ApiResources
    {
        // scopes define the API resources in your system
        public static IEnumerable<ApiResource> GetAll()
        {
            return new List<ApiResource>
            {
                new ApiResource("scope.bgmvc", "BG MVC"),
                new ApiResource("scope.readaccess", "Example API"),
                new ApiResource("scope.fullaccess", "Example API"),
                new ApiResource("YouCanActuallyDefineTheScopesAsYouLike", "Example API")
            };
        }
    }
}

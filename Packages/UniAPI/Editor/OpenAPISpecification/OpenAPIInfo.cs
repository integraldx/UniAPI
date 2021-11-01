using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISpecification
{
    [JsonObject]
    public class OpenAPIInfo
    {
        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("version")] public string Version { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("termsOfService")] public string TermsOfService { get; set; }

        [JsonProperty("contact")] public IDictionary<string, object> Contact { get; set; }

        [JsonProperty("license")] public IDictionary<string, object> License { get; set; }
    }
}

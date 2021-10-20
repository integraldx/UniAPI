using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISchema
{
    [JsonObject]
    public class OpenAPI
    {
        [JsonProperty("openapi")] public string OpenAPIVersion { get; }

        [JsonProperty("info")] public IDictionary<string, object> Info { get; }

        [JsonProperty("servers")] public IList<object> Servers { get; }

        [JsonProperty("paths")] public IDictionary<string, object> Paths { get; }

        [JsonProperty("components")] public IDictionary<string, object> Components { get; }

        [JsonProperty("security")] public IList<object> Security { get; }

        [JsonProperty("tags")] public IList<object> Tags { get; }

        [JsonProperty("externalDocs")] public IDictionary<string, object> ExternalDocs { get; }
    }
}

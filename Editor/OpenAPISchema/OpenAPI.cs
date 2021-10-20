using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISchema
{
    [JsonObject]
    public class OpenAPI
    {
        [JsonProperty("openapi"), JsonRequired] public string OpenAPIVersion { get; set; }

        [JsonProperty("info"), JsonRequired] public OpenAPIInfo Info { get; set; }

        [JsonProperty("servers")] public IList<object> Servers { get; set; }

        [JsonProperty("paths")] public IDictionary<string, object> Paths { get; set; }

        [JsonProperty("components")] public IDictionary<string, object> Components { get; set; }

        [JsonProperty("security")] public IList<object> Security { get; set; }

        [JsonProperty("tags")] public IList<object> Tags { get; set; }

        [JsonProperty("externalDocs")] public IDictionary<string, object> ExternalDocs { get; set; }
    }
}

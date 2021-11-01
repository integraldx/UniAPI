using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISpecification
{
    [JsonObject]
    public class OpenAPIComponents
    {
        [JsonProperty("schemas")] public Dictionary<string, object> Schemas { get; set; }

        [JsonProperty("responses")] public Dictionary<string, object> Responses { get; set; }

        [JsonProperty("parameters")] public Dictionary<string, object> Parameters { get; set; }

        [JsonProperty("examples")] public Dictionary<string, object> Examples { get; set; }

        [JsonProperty("requestBodies")] public Dictionary<string, object> RequestBodies { get; set; }

        [JsonProperty("headers")] public Dictionary<string, object> Headers { get; set; }

        [JsonProperty("securitySchemes")] public Dictionary<string, object> SecuritySchemes { get; set; }

        [JsonProperty("links")] public Dictionary<string, object> Links { get; set; }

        [JsonProperty("callbacks")] public Dictionary<string, object> Callbacks { get; set; }
    }
}

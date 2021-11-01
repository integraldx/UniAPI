using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISpecification
{
    [JsonObject]
    public class OpenAPIPathItem
    {
        [JsonProperty("summary")] public string Summary { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("get")] public OpenAPIOperation Get { get; set; }

        [JsonProperty("put")] public OpenAPIOperation Put { get; set; }

        [JsonProperty("post")] public OpenAPIOperation Post { get; set; }

        [JsonProperty("delete")] public OpenAPIOperation Delete { get; set; }

        [JsonProperty("options")] public OpenAPIOperation Options { get; set; }

        [JsonProperty("head")] public OpenAPIOperation Head { get; set; }

        [JsonProperty("patch")] public OpenAPIOperation Patch { get; set; }

        [JsonProperty("trace")] public OpenAPIOperation Trace { get; set; }

        [JsonProperty("servers")] public IList<object> Servers { get; set; }

        [JsonProperty("parameters")] public IList<object> Parameters { get; set; }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISchema
{
    [JsonObject]
    public class OpenAPIOperation
    {
        [JsonProperty("tags")] public IList<string> Tags { get; set; }
        [JsonProperty("summary")] public string Summary { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("externalDocs")] public IDictionary<string, object> ExternalDocs { get; set; }

        [JsonProperty("operationId")] public string OperationID { get; set; }

        [JsonProperty("parameters")] public IList<object> Parameters { get; set; }

        [JsonProperty("requestBody")] public IDictionary<string, object> RequestBody { get; set; }

        [JsonProperty("responses")] public IDictionary<string, object> Responses { get; set; }

        [JsonProperty("callbacks")] public IDictionary<string, object> Callbacks { get; set; }

        [JsonProperty("deprecated")] public bool Deprecated { get; set; }

        [JsonProperty("security")] public IList<object> Security { get; set; }

        [JsonProperty("servers")] public IList<object> Servers { get; set; }
    }
}

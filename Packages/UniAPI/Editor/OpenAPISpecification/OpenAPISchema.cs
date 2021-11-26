using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Integraldx.UniAPI.Editor.OpenAPISpecification
{
    [JsonObject]
    public class OpenAPISchema
    {
        [JsonProperty("title"), CanBeNull] public string Title { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("description"), CanBeNull] public string Description { get; set; }

        [JsonProperty("multipleOf")] public float? MultipleOf { get; set; }

        [JsonProperty("maximum")] public float? Maximum { get; set; }

        [JsonProperty("exclusiveMaximum")] public bool? ExclusiveMaximum { get; set; }

        [JsonProperty("minimum")] public float? Minimum { get; set; }

        [JsonProperty("exclusiveMinimum")] public bool? ExclusiveMinimum { get; set; }

        [JsonProperty("maxLength")] public long? MaxLength { get; set; }

        [JsonProperty("minLength")] public long? MinLength { get; set; }

        [JsonProperty("pattern"), CanBeNull] public Regex Pattern { get; set; }

        [JsonProperty("maxItems")] public long? MaxItems { get; set; }

        [JsonProperty("minItems")] public long? MinItems { get; set; }

        [JsonProperty("uniqueItems")] public bool? UniqueItems { get; set; }

        [JsonProperty("maxProperties")] public long? MaxProperties { get; set; }

        [JsonProperty("minProperties")] public long? MinProperties { get; set; }

        [JsonProperty("required"), CanBeNull] public string[] Required { get; set; }

        [JsonProperty("enum"), CanBeNull] public object[] Enum { get; set; }

        [JsonProperty("allOf"), CanBeNull] public OpenAPISchema[] AllOf { get; set; }

        [JsonProperty("oneOf"), CanBeNull] public OpenAPISchema[] OneOf { get; set; }

        [JsonProperty("anyOf"), CanBeNull] public OpenAPISchema[] AnyOf { get; set; }

        [JsonProperty("not"), CanBeNull] public OpenAPISchema[] Not { get; set; }

        [JsonProperty("items"), CanBeNull] public OpenAPISchema Items { get; set; }

        [JsonProperty("properties"), CanBeNull] public Dictionary<string, OpenAPISchema> Properties { get; set; }

        [JsonProperty("additionalProperties"), CanBeNull] public object AdditionalProperties { get; set; }

        [JsonProperty("format"), CanBeNull] public string Format { get; set; }

        [JsonProperty("default"), CanBeNull] public Dictionary<string, object> Default { get; set; }

        [JsonProperty("nullable"), CanBeNull] public bool? Nullable { get; set; }

        [JsonProperty("discriminator"), CanBeNull] public Dictionary<string, object> Discriminator { get; set; }

        [JsonProperty("readOnly"), CanBeNull] public bool? ReadOnly { get; set; }

        [JsonProperty("writeOnly"), CanBeNull] public bool? WriteOnly { get; set; }

        [JsonProperty("xml"), CanBeNull] public Dictionary<string, object> Xml { get; set; }

        [JsonProperty("externalDocs"), CanBeNull] public Dictionary<string, object> ExternalDocs { get; set; }

        [JsonProperty("example"), CanBeNull] public string Example { get; set; }

        [JsonProperty("deprecated")] public bool Deprecated { get; set; }
    }
}

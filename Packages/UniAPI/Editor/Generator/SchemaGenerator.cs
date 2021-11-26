using System.Collections.Generic;
using System.Text;
using Integraldx.UniAPI.Editor.OpenAPISpecification;

namespace Integraldx.UniAPI.Editor.Generator
{
    public class SchemaGenerator
    {
        private readonly StringBuilder _stringBuilder;

        internal SchemaGenerator()
        {
            _stringBuilder = new StringBuilder();
        }

        public string GenerateSchema(OpenAPI openAPI)
        {
            var schemaDict = FindSchemaList();

            foreach (var keyValuePair in schemaDict)
            {
                _stringBuilder.Append($"public class {keyValuePair.Key}\n");
                _stringBuilder.Append("{\n");
                _stringBuilder.Append("}\n");
                _stringBuilder.Append("\n");
            }

            return _stringBuilder.ToString();

            Dictionary<string, OpenAPISchema> FindSchemaList()
            {
                var result = openAPI.Components.Schemas;

                return result;
            }
        }
    }
}

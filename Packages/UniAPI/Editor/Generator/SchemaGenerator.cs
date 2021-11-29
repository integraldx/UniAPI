using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integraldx.UniAPI.Editor.CodeGenerator;
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

            foreach (var @class in schemaDict.Select(keyValuePair => CSharpClass.GetNewClass(keyValuePair.Key)))
            {
                _stringBuilder.Append(@class);
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

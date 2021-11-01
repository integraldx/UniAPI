using System.Text;
using Integraldx.UniAPI.Editor.OpenAPISpecification;
using NUnit.Framework;

namespace Integraldx.UniAPI.Editor.Generator
{
    public class InterfaceGenerator
    {
        private StringBuilder StringBuilder { get; }

        internal InterfaceGenerator()
        {
            StringBuilder = new StringBuilder();
        }

        public string GenerateInterface(OpenAPI api)
        {
            StringBuilder.Append("public interface IOpenAPI\n{\n");

            foreach (var pathPair in api.Paths)
            {
                HandlePath(StringBuilder, pathPair.Value);
            }

            StringBuilder.Append("}\n");

            return StringBuilder.ToString();

            static void HandlePath(StringBuilder sb, OpenAPIPathItem pathItem)
            {
                if (pathItem.Get != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Get.OperationID)}();\n");
                }

                if (pathItem.Put != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Put.OperationID)}();\n");
                }

                if (pathItem.Post != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Post.OperationID)}();\n");
                }

                if (pathItem.Delete != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Delete.OperationID)}();\n");
                }

                if (pathItem.Options != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Options.OperationID)}();\n");
                }

                if (pathItem.Head != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Head.OperationID)}();\n");
                }

                if (pathItem.Patch != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Patch.OperationID)}();\n");
                }

                if (pathItem.Trace != null)
                {
                    sb.Append($"    public void {OperationIDToPascalCase(pathItem.Trace.OperationID)}();\n");
                }
            }

            static string OperationIDToPascalCase(string operationId)
            {
                Assert.IsFalse(string.IsNullOrEmpty(operationId));

                var first = operationId.Substring(0, 1).ToUpper();
                var second = operationId.Substring(1, operationId.Length - 1);
                return first + second;
            }
        }
    }
}

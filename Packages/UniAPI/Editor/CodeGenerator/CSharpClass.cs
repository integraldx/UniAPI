using System.Text;

namespace Integraldx.UniAPI.Editor.CodeGenerator
{
    internal class CSharpClass
    {
        public static CSharpClass GetNewClass(string name)
        {
            var @class = new CSharpClass
            {
                Name = name,
            };

            return @class;
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"public class {Name}\n");
            stringBuilder.Append("{\n");
            stringBuilder.Append("}\n");

            return stringBuilder.ToString();
        }
    }
}

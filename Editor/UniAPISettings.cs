using UnityEditor;
using UnityEngine;

namespace Integraldx.UniAPI.Editor
{
    [CreateAssetMenu(fileName = "UniAPISettings", menuName = "UniAPI/Settings")]
    public class UniAPISettings : ScriptableSingleton<UniAPISettings>
    {
        [SerializeField]
        [InspectorName("OpenAPI specification file")]
        private TextAsset _apiSpecificationFile;

        public TextAsset APISpecificationFile => _apiSpecificationFile;
    }
}

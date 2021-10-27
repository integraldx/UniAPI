using UnityEngine;

namespace Integraldx.UniAPI.Editor
{
    [CreateAssetMenu(fileName = "UniAPISettings", menuName = "UniAPI/Settings")]
    public class UniAPISettings : ScriptableObject
    {
        [SerializeField]
        [InspectorName("OpenAPI specification file")]
        private TextAsset _apiSpecificationFile;

        public TextAsset APISpecificationFile => _apiSpecificationFile;
    }
}

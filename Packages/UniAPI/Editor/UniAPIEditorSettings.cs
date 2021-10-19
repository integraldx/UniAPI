using UnityEditor;
using UnityEngine;

namespace Integraldx.UniAPI.Editor
{
    [FilePath("ProjectSettings/Packages/com.integraldx.uniapi/Settings.yaml", FilePathAttribute.Location.ProjectFolder)]
    public class UniAPIEditorSettings : ScriptableSingleton<UniAPIEditorSettings>
    {
        [SerializeField] private GUID _settingsGUID;

        public GUID SettingsGUID
        {
            get => _settingsGUID;
            set
            {
                _settingsGUID = value;
                Save(true);
            }
        }
    }
}

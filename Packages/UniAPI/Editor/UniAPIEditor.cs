using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Integraldx.UniAPI.Editor
{
    [InitializeOnLoad]
    public static class UniAPIEditor
    {
        static UniAPIEditor()
        {
            LogEditor();
        }

        private static void LogEditor()
        {
            Debug.Log("UniAPI v0.1.0");
        }

        [MenuItem("UniAPI/Generate")]
        public static void GenerateCodes()
        {
            var resultGUIDs = AssetDatabase.FindAssets("t:UniAPISettings");

            UniAPISettings settings;

            switch (resultGUIDs.Length)
            {
                case 1:
                    var resultGUIDString = resultGUIDs[0];

                    if (!GUID.TryParse(resultGUIDString, out var resultGUID))
                    {
                        throw new ApplicationException("Unity has returned invalid GUID!");
                    }

                    UniAPIEditorSettings.instance.SettingsGUID = resultGUID;

                    settings = AssetDatabase.LoadAssetAtPath<UniAPISettings>(
                        AssetDatabase.GUIDToAssetPath(UniAPIEditorSettings.instance.SettingsGUID));
                    break;

                default:
                    Debug.LogError("There is none, two or more UniAPI settings file! Make sure there is only one.");
                    return;
            }

            var dict = JsonUtility.FromJson<Dictionary<string, object>>(settings.APISpecificationFile.text);
            Debug.Log(dict);
        }
    }
}

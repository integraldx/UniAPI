using System;
using System.Collections.Generic;
using Integraldx.UniAPI.Editor.OpenAPISchema;
using Newtonsoft.Json;
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
            var settings = FetchSettings();

            var openAPI = JsonConvert.DeserializeObject<OpenAPI>(settings.APISpecificationFile.text);
            Debug.Log(openAPI);
            Debug.Log(openAPI.OpenAPIVersion);
        }

        private static UniAPISettings FetchSettings()
        {
            var searchResult = AssetDatabase.FindAssets("t:UniAPISettings");

            switch (searchResult.Length)
            {
                case 1:
                    var resultGUIDString = searchResult[0];

                    if (!GUID.TryParse(resultGUIDString, out var resultGUID))
                    {
                        throw new ApplicationException("Unity has returned invalid GUID!");
                    }

                    UniAPIEditorSettings.instance.SettingsGUID = resultGUID;

                    return AssetDatabase.LoadAssetAtPath<UniAPISettings>(
                        AssetDatabase.GUIDToAssetPath(UniAPIEditorSettings.instance.SettingsGUID));

                default:
                    const string errorMessage = "There is none, two or more UniAPI settings file! Make sure there is only one.";
                    Debug.LogError(errorMessage);
                    throw new ArgumentNullException(errorMessage);
            }
        }
    }
}

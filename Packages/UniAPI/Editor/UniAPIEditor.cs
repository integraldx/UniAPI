using System;
using System.IO;
using Integraldx.UniAPI.Editor.Generator;
using Integraldx.UniAPI.Editor.OpenAPISpecification;
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

            PromptAPIInfos(openAPI);

            var generator = new InterfaceGenerator();

            var content = generator.GenerateInterface(openAPI);

            File.WriteAllText("./Assets/Interface.cs", content);

            AssetDatabase.Refresh();
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

        private static void PromptAPIInfos(OpenAPI openAPI)
        {
            Debug.Log($"Using OpenAPI version {openAPI.OpenAPIVersion}");

            Debug.Log($"Converting {openAPI.Info.Title} : {openAPI.Info.Version}");

            foreach (var path in openAPI.Paths)
            {
                if (path.Value.Get != null)
                {
                    Debug.Log($"{path.Key}/Get : {path.Value.Get}");
                }

                if (path.Value.Put != null)
                {
                    Debug.Log($"{path.Key}/Put : {path.Value.Put}");
                }

                if (path.Value.Post != null)
                {
                    Debug.Log($"{path.Key}/Post : {path.Value.Post}");
                }

                if (path.Value.Delete != null)
                {
                    Debug.Log($"{path.Key}/Delete : {path.Value.Get}");
                }

                if (path.Value.Options != null)
                {
                    Debug.Log($"{path.Key}/Options : {path.Value.Options}");
                }

                if (path.Value.Head != null)
                {
                    Debug.Log($"{path.Key}/Head : {path.Value.Head}");
                }

                if (path.Value.Patch != null)
                {
                    Debug.Log($"{path.Key}/Patch : {path.Value.Patch}");
                }

                if (path.Value.Trace != null)
                {
                    Debug.Log($"{path.Key}/Trace : {path.Value.Trace}");
                }
            }
        }
    }
}

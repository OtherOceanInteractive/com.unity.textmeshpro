﻿using System.IO;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEditor;


namespace TMPro.EditorUtilities
{

    public static class TMP_StyleAssetMenu
    {

        [MenuItem("Assets/Create/TextMeshPro/Style Sheet", false, 200)]
        internal static void CreateTextMeshProObjectPerform()
        {
            string filePath;
            if (Selection.assetGUIDs.Length == 0)
            {
                // No asset selected.
                filePath = "Assets";
            }
            else
            {
                // Get the path of the selected folder or asset.
                filePath = AssetDatabase.GUIDToAssetPath(Selection.assetGUIDs[0]);

                // Get the file extension of the selected asset as it might need to be removed.
                string fileExtension = Path.GetExtension(filePath);
                if (fileExtension != "")
                {
                    filePath = Path.GetDirectoryName(filePath);
                }
            }

            string filePathWithName = AssetDatabase.GenerateUniqueAssetPath(filePath + "/Text StyleSheet.asset");

            //// Create new Style Sheet Asset.
            TextStyleSheet styleSheet = ScriptableObject.CreateInstance<TextStyleSheet>();

            // Create Normal default style
            TextStyle style = new TextStyle("Normal", string.Empty, string.Empty);
            styleSheet.styles.Add(style);

            AssetDatabase.CreateAsset(styleSheet, filePathWithName);

            EditorUtility.SetDirty(styleSheet);

            AssetDatabase.SaveAssets();

            EditorUtility.FocusProjectWindow();
            EditorGUIUtility.PingObject(styleSheet);
        }
    }
}

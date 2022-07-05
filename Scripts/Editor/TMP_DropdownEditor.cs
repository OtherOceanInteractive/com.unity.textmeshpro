using UnityEngine;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine.UI;

namespace TMPro.EditorUtilities
{
    [CustomEditor(typeof(TMP_Dropdown), true)]
    [CanEditMultipleObjects]
    public class DropdownEditor : SelectableEditor
    {
        SerializedProperty m_Template;
        SerializedProperty m_CaptionText;
        SerializedProperty m_CaptionImage;
        SerializedProperty m_Placeholder;
        SerializedProperty m_ItemText;
        SerializedProperty m_ItemImage;
        SerializedProperty m_OnSelectionChanged;
        // OOI_CC begin
        SerializedProperty m_OnDropdownShown;
        SerializedProperty m_OnDropdownHidden;
        // OOI_CC end
        SerializedProperty m_Value;
        SerializedProperty m_AlphaFadeSpeed;
        SerializedProperty m_Options;

        protected override void OnEnable()
        {
            base.OnEnable();
            m_Template = serializedObject.FindProperty("m_Template");
            m_CaptionText = serializedObject.FindProperty("m_CaptionText");
            m_CaptionImage = serializedObject.FindProperty("m_CaptionImage");
            m_Placeholder = serializedObject.FindProperty("m_Placeholder");
            m_ItemText = serializedObject.FindProperty("m_ItemText");
            m_ItemImage = serializedObject.FindProperty("m_ItemImage");
            m_OnSelectionChanged = serializedObject.FindProperty("m_OnValueChanged");
            // OOI_CC begin
            m_OnDropdownShown = serializedObject.FindProperty("m_OnDropdownShown");
            m_OnDropdownHidden = serializedObject.FindProperty("m_OnDropdownHidden");
            // OOI_CC end
            m_Value = serializedObject.FindProperty("m_Value");
            m_AlphaFadeSpeed = serializedObject.FindProperty("m_AlphaFadeSpeed");
            m_Options = serializedObject.FindProperty("m_Options");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.Space();

            serializedObject.Update();
            EditorGUILayout.PropertyField(m_Template);
            EditorGUILayout.PropertyField(m_CaptionText);
            EditorGUILayout.PropertyField(m_CaptionImage);
            EditorGUILayout.PropertyField(m_Placeholder);
            EditorGUILayout.PropertyField(m_ItemText);
            EditorGUILayout.PropertyField(m_ItemImage);
            EditorGUILayout.PropertyField(m_Value);
            EditorGUILayout.PropertyField(m_AlphaFadeSpeed);
            EditorGUILayout.PropertyField(m_Options);
            EditorGUILayout.PropertyField(m_OnSelectionChanged);
            // OOI_CC begin
            EditorGUILayout.PropertyField(m_OnDropdownShown);
            EditorGUILayout.PropertyField(m_OnDropdownHidden);
            // OOI_CC end
            serializedObject.ApplyModifiedProperties();
        }
    }
}

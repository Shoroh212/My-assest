using UnityEngine;
using UnityEditor;

public static class HierarchyColorTool
{
    [InitializeOnLoadMethod]
    private static void Initialize()
    {
        EditorApplication.hierarchyWindowItemOnGUI += DrawHierarchy;
    }

    private static void DrawHierarchy(int instanceID, Rect selectionRect)
    {
        Debug.Log("Unity рисует строку Hierarchy");
    }
}
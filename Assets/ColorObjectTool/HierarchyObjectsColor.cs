
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class HierarchyColorTool
{
    private static GameObject coloredObject;

    static HierarchyColorTool()
    {
        EditorApplication.hierarchyWindowItemOnGUI +=
            DrawHierarchy;
    }

    private static void DrawHierarchy(
        int instanceID,
        Rect selectionRect)
    {
        if (coloredObject == null)
            return;

        if (coloredObject.GetInstanceID() != instanceID)
            return;

        EditorGUI.DrawRect(
            selectionRect,
            new Color(1f, 0f, 0f, 0.3f)
        );
    }

    [MenuItem("GameObject/Custom Tools/Set Red", false, 49)]
    private static void SetRed()
    {
        if (Selection.activeGameObject == null)
            return;

        coloredObject = Selection.activeGameObject;

        EditorApplication.RepaintHierarchyWindow();
    }
}

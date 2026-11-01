
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class HierarchyColorTool
{
    private static GameObject coloredObject;
    const int _Ordernumber = 14;

    static HierarchyColorTool()
    {
        EditorApplication.hierarchyWindowItemOnGUI +=
            DrawHierarchy;

    }

    private static void DrawHierarchy(int instanceID,  Rect selectionRect)
    {
        if (coloredObject == null)
            return;
        if (coloredObject.GetInstanceID() != instanceID)
            return;

        EditorGUI.DrawRect( selectionRect,new Color(1f, 0f, 0f, 0.3f)
        );
    }

    [MenuItem("GameObject/Give color/Set Red", false, _Ordernumber)]
    private static void SetRed()
    {
        if (Selection.activeGameObject == null)
            return;

        coloredObject = Selection.activeGameObject;

        EditorApplication.RepaintHierarchyWindow();
    }
}

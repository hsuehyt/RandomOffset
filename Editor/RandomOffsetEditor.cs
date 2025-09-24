using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomOffset))]
[CanEditMultipleObjects]  // allows editing multiple objects at once
public class RandomOffsetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default inspector first
        DrawDefaultInspector();
        EditorGUILayout.Space();

        // Add Randomize Seed button
        if (GUILayout.Button("Randomize Seed"))
        {
            foreach (var t in targets)
            {
                var comp = t as RandomOffset;
                if (comp == null) continue;

                Undo.RecordObject(comp, "Randomize Seed");
                comp.randomSeed = Random.Range(1, 9999); // safe integer range
                EditorUtility.SetDirty(comp);
            }
        }
    }
}

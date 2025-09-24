using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomOffset))]
public class RandomOffsetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RandomOffset script = (RandomOffset)target;

        if (GUILayout.Button("Randomize Seed"))
        {
            Undo.RecordObject(script, "Randomize Seed");
            script.randomSeed = Random.Range(1, 9999);
            EditorUtility.SetDirty(script);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (MapGenerator))]
public class MapGenEditor : Editor
{
    public override void OnInspectorGUI()
    {
     MapGenerator mapGen = (MapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.generateMap();
            }
        }
        if (GUILayout.Button("Generate"))
        {
            mapGen.generateMap();
        }

    }
}

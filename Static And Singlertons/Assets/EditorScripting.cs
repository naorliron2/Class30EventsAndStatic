using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(InstantiateNew))]
public class EditorScripting : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        InstantiateNew mytarget = (InstantiateNew)target;

        if (GUILayout.Button("New Instance"))
        {
            mytarget.createNewInstance();
        }
    }
}

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ManagerObject))]
public class ManagerObjectEditor : Editor
{
    private ManagerObject managerObject;

    private void OnEnable()
    {
        managerObject = (ManagerObject)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("add Action Node"))
            managerObject.AddNode(new ActionTypeNode());

        if (GUILayout.Button("add Rule Node"))
            managerObject.AddNode(new RuleTypeNode());

        if (GUILayout.Button("Clear Nodes"))
            managerObject.ClearNodes();
    }
}

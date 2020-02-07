using System.Collections.Generic;
using UnityEngine;

public class ManagerObject : MonoBehaviour
{
    [SerializeReference]
    public List<INode> nodes;

    public void AddNode(INode node)
    {
        nodes.Add(node);
    }

    public void ClearNodes()
    {
        nodes.Clear();
    }
}

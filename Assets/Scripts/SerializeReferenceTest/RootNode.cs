using System;
using UnityEngine;

public interface INode { }

[Serializable]
public class RootNode : INode
{
    [SerializeReference] public INode left;
    [SerializeReference] public INode right;
}

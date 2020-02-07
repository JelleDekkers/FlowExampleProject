using UnityEngine;
using Utils.Core.Flow;

public class TestAction : StateAction
{
    [SerializeField] private float testValue;

    public override void OnStarting() { }

    public override void OnStarted() { }

    public override void Update() { }

    public override void OnStopping() { }

    public override void OnStopped() { }
}

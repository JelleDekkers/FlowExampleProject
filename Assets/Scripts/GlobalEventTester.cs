using System;
using UnityEngine;
using Utils.Core;
using Utils.Core.Events;
using Utils.Core.Services;

public class GlobalEventTester : MonoBehaviour
{
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference invokeEventType = null;

    private EventDispatcher eventDispatcher;

    private void Start()
    {
        eventDispatcher = GlobalServiceLocator.Instance.Get<GlobalEventDispatcher>();
        eventDispatcher.Subscribe<TestEvent>(OnTestEventInvokedEvent);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventDispatcher.Invoke(Activator.CreateInstance(invokeEventType) as IEvent);
        }
    }

    private void OnTestEventInvokedEvent(TestEvent testEvent)
    {
        Debug.Log("Test Event was called");
    }
}

public class TestEvent : IEvent
{

}
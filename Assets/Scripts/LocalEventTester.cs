using System;
using UnityEngine;
using Utils.Core;
using Utils.Core.Events;

public class LocalEventTester : MonoBehaviour
{
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference invokeEventType = null;

    private EventDispatcher eventDispatcher;
    public void InjectDependencies(EventDispatcher eventDispatcher)
    {
        this.eventDispatcher = eventDispatcher;
        eventDispatcher.Subscribe<TestEvent>(OnTestEventInvokedEvent);
    }

    private void OnTestEventInvokedEvent(TestEvent obj)
    {
        Debug.Log("received local " + obj);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            eventDispatcher.Invoke(Activator.CreateInstance(invokeEventType) as IEvent);
        }
    }
}

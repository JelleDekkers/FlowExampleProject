using System;
using UnityEngine;
using UnityEngine.UI;
using Utils.Core;
using Utils.Core.Events;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference startButtonClickedEvent;

    private EventDispatcher eventDispatcher;

    public void InjectDependencies(EventDispatcher eventDispatcher)
    {
        this.eventDispatcher = eventDispatcher;
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(OnStartButtonClickedEvent);
        quitButton.onClick.AddListener(OnQuitButtonClickedEvent);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(OnStartButtonClickedEvent);
        quitButton.onClick.RemoveListener(OnQuitButtonClickedEvent);
    }

    private void OnStartButtonClickedEvent()
    {
        eventDispatcher.Invoke((IEvent)Activator.CreateInstance(startButtonClickedEvent));
    }

    private void OnQuitButtonClickedEvent()
    {
        eventDispatcher.Invoke(new ExitEvent());
    }
}

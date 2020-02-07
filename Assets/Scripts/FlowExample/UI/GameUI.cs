using System;
using UnityEngine;
using UnityEngine.UI;
using Utils.Core;
using Utils.Core.Events;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Button gameOverButton;
    [SerializeField] private Button quitButton;
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference gameOverButtonClickedEvent;
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference quitButtonClickedEvent;

    private EventDispatcher eventDispatcher;

    public void InjectDependencies(EventDispatcher eventDispatcher)
    {
        this.eventDispatcher = eventDispatcher;
    }

    private void OnEnable()
    {
        gameOverButton.onClick.AddListener(OnGameOverButtonClickedEvent);
        quitButton.onClick.AddListener(OnQuitButtonClickedEvent);
    }

    private void OnDisable()
    {
        gameOverButton.onClick.RemoveListener(OnGameOverButtonClickedEvent);
        quitButton.onClick.RemoveListener(OnQuitButtonClickedEvent);
    }

    private void OnGameOverButtonClickedEvent()
    {
        eventDispatcher.Invoke((IEvent)Activator.CreateInstance(gameOverButtonClickedEvent));
    }

    private void OnQuitButtonClickedEvent()
    {
        eventDispatcher.Invoke((IEvent)Activator.CreateInstance(quitButtonClickedEvent));
    }
}

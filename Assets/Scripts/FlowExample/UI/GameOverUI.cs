using System;
using UnityEngine;
using UnityEngine.UI;
using Utils.Core;
using Utils.Core.Events;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button replayButton;
    [SerializeField] private Button quitButton;
    [ClassTypeImplements(typeof(IEvent)), SerializeField] private ClassTypeReference gameOverButtonClickedEvent;

    private EventDispatcher eventDispatcher;

    public void InjectDependencies(EventDispatcher eventDispatcher)
    {
        this.eventDispatcher = eventDispatcher;
    }

    private void OnEnable()
    {
        replayButton.onClick.AddListener(OnReplayButtonClickedEvent);
        quitButton.onClick.AddListener(OnQuitButtonClickedEvent);
    }

    private void OnDisable()
    {
        replayButton.onClick.RemoveListener(OnReplayButtonClickedEvent);
        quitButton.onClick.RemoveListener(OnQuitButtonClickedEvent);
    }

    private void OnReplayButtonClickedEvent()
    {
        eventDispatcher.Invoke((IEvent)Activator.CreateInstance(gameOverButtonClickedEvent));
    }

    private void OnQuitButtonClickedEvent()
    {
        eventDispatcher.Invoke(new ExitEvent());
    }
}

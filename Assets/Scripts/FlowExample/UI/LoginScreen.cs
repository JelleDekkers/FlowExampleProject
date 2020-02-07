using UnityEngine;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
    [SerializeField] private Button loginButton;

    private LoginService loginService;

    public void InjectDependencies(LoginService loginService)
    {
        this.loginService = loginService;
    }

    private void OnEnable()
    {
        loginButton.onClick.AddListener(OnLoginButtonClickedEvent);
    }

    private void OnDisable()
    {
        loginButton.onClick.RemoveListener(OnLoginButtonClickedEvent);
    }

    private void OnLoginButtonClickedEvent()
    {
        loginService.Login();
    }
}

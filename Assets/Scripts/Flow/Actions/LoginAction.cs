using Utils.Core.Flow;

public class LoginAction : StateAction
{
    private LoginService loginService;

    public void InjectDependencies(LoginService loginService)
    {
        this.loginService = loginService;
    }

    public override void OnStarted()
    {
        loginService.Login();
    }
}

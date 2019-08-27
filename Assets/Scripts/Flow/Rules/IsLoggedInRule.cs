using Utils.Core.Flow;

public class IsLoggedInRule : Rule
{
    public override bool IsValid => loginService.IsLoggedIn;
    public override string DisplayName => "Is logged in";

    private LoginService loginService;

    public void InjectDependencies(LoginService loginService)
    {
        this.loginService = loginService;
    }
}

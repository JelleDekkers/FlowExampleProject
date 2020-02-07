using Utils.Core.Services;

public class LoginService : IService
{
    public bool IsLoggedIn { get; private set; }
    public ILoginServer server;

    public LoginService(ILoginServer server)
    {
        this.server = server;
    }

    public void Login()
    {
        IsLoggedIn = server.Login();
    }

    public void Logout()
    {
        IsLoggedIn = false;
    }
}

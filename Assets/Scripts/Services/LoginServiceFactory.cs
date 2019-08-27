using Utils.Core.Services;

/// <summary>
/// Service factory for <see cref="LoginService"/>. 
/// Constructs <see cref="LoginService"/> with <see cref="MockServer"/> or <see cref="LoginServer"/> depending on <see cref="useMockData"/>
/// </summary>
public class LoginServiceFactory : IServiceFactory<LoginService>
{
    // this could for instance be a Settings ScriptableObject in the editor
    public bool useMockData = false;

    public LoginService Construct()
    {
        ILoginServer server;
        if(useMockData)
        {
            server = new MockServer();
        }
        else
        {
            server = new LoginServer();
        }

        return new LoginService(server);
    }
}

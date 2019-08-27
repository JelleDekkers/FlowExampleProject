using UnityEngine;

public interface ILoginServer
{
    bool Login();
}

/// <summary>
/// Mock class for testing the app without connecting to a real server
/// </summary>
public class MockServer : ILoginServer
{
    public bool Login()
    {
        Debug.Log("Logged in via mock server");
        return true;
    }
}

/// <summary>
/// The real server implementation
/// </summary>
public class LoginServer : ILoginServer
{
    public bool Login()
    {
        Debug.Log("Logged in via real server");
        return true;
    }
}

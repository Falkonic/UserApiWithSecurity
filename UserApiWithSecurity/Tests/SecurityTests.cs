using Xunit;

public class SecurityTests
{
    [Fact]
    public void TestSQLInjectionFails()
    {
        string maliciousInput = "' OR '1'='1";
        bool result = Program.AuthenticateUser(maliciousInput, "irrelevant");
        Assert.False(result); // SQL Injection muss scheitern
    }

    [Fact]
    public void TestValidLoginSucceeds()
    {
        bool result = Program.AuthenticateUser("user1", "password123");
        Assert.True(result); // Benutzer ist korrekt
    }
}

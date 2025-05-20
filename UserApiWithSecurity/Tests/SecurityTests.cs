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
    // Copilot generated this test structure to verify login security
    [Fact]
    public void Test_SQLInjectionBlocked()
    {
        bool result = Program.AuthenticateUser("' OR '1'='1", "irrelevant");
        Assert.False(result); // SQL Injection should not work
    }   

    [Fact]
    public void Test_ValidUserPasses()
    {
        bool result = Program.AuthenticateUser("admin", "admin123");
        Assert.True(result); // Hardcoded test user
    }
}

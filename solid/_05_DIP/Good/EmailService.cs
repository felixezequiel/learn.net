namespace Solid._05_DIP.Good;

public interface IEmailService
{
    void Send();
}

public class EmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine($"Sending email");
    }
}

public class UserService(IEmailService emailService)
{
    public void Register(string email, string password)
    {
        emailService.Send();
    }
}

public class FakeEmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine($"Sending fake email");
    }
}
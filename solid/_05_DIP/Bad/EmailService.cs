namespace Solid._05_DIP.Bad;

public class EmailService
{
    public void Send()
    {
        Console.WriteLine($"Sending email");
    }
}

public class UserService(EmailService emailService)
{
    public void Register(string email, string password)
    {
        emailService.Send();
    }
}
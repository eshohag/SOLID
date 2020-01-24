namespace DependencyInversionPrinciple
{
    public interface IEmailService
    {
        bool SendEmailService(string email, string message);
    }
}

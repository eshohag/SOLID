namespace SingleResponsiblePrinciple
{
    public interface IUserService
    {
        bool LoginService(string username, string password);
        bool RegisterService(User aUser);
    }
}

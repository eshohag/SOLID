namespace InterfaceSegregationPrinciple
{
    interface IUserManager
    {
        bool LoggedIn(string userName, string password);
        bool Register(User aUser, bool sentEmailConfirmation);
    }
}

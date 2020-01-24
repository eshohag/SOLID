using System;

namespace SingleResponsiblePrinciple
{
    public class UserManager : IUserManager
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public UserManager(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        public bool LoggedIn(string userName, string password)
        {
            return _userService.LoginService(userName, password);
        }

        public bool Register(User aUser, bool sentEmailConfirmation)
        {
            bool registeredUser = _userService.RegisterService(aUser);
            if (sentEmailConfirmation && registeredUser)
            {
                return _emailService.SendEmailService(aUser.Email, "Successfully registered!");
            }
            return false;
        }
    }
}

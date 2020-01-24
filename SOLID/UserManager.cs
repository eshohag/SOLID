namespace SOLID
{
    public class UserManager : IUserManager
    {
        private readonly IUserService _userService;
        private readonly IRegisterService _registerService;
        private readonly IEmailService _emailService;
        private readonly IBlacklistedUser _blacklistedUser;

        public UserManager(IUserService userService,
            IRegisterService registerService,
            IEmailService emailService,
            IBlacklistedUser blacklistedUser)
        {
            _userService = userService;
            _registerService = registerService;
            _emailService = emailService;
            _blacklistedUser = blacklistedUser;
        }
        public bool LoggedIn(string userName, string password)
        {
            return _userService.LoginService(userName, password);
        }

        public bool Register(User aUser, bool sentEmailConfirmation)
        {
            bool registeredUser = !_blacklistedUser.CheckUser(aUser) && _registerService.Register(aUser);

            if (sentEmailConfirmation && registeredUser)
            {
                return _emailService.SendEmailService(aUser.Email, "Successfully registered!");
            }
            return false;
        }
    }
}

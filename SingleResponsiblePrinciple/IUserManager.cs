using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblePrinciple
{
    interface IUserManager
    {
        bool LoggedIn(string userName, string password);
        bool Register(User aUser, bool sentEmailConfirmation);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    public interface IBlacklistedUser
    {
        bool CheckUser(User aUser);
    }
}

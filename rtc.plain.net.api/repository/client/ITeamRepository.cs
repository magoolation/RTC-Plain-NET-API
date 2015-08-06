using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.client
{
    public interface ITeamRepository
    {
        void registerLoginHandler(LoginHandler loginHandler);
        void login(object monitor);
        void setMayLogIntoJts(bool v);
    }
}

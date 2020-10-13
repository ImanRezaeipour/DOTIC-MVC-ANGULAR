using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace PTC.DOTIC.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}

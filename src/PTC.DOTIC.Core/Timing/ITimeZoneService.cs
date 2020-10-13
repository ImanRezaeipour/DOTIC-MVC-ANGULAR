using System.Threading.Tasks;
using Abp.Configuration;

namespace PTC.DOTIC.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}

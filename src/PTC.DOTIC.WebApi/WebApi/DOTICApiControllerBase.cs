using Abp.WebApi.Controllers;

namespace PTC.DOTIC.WebApi
{
    public abstract class DOTICApiControllerBase : AbpApiController
    {
        protected DOTICApiControllerBase()
        {
            LocalizationSourceName = DOTICConsts.LocalizationSourceName;
        }
    }
}
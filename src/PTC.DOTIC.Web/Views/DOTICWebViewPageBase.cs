using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace PTC.DOTIC.Web.Views
{
    public abstract class DOTICWebViewPageBase : DOTICWebViewPageBase<dynamic>
    {
       
    }

    public abstract class DOTICWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected DOTICWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = DOTICConsts.LocalizationSourceName;
        }
    }
}
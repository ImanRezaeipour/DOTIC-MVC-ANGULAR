using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using PTC.DOTIC.EntityFramework;

namespace PTC.DOTIC.Migrator
{
    [DependsOn(typeof(DOTICDataModule))]
    public class DOTICMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DOTICDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
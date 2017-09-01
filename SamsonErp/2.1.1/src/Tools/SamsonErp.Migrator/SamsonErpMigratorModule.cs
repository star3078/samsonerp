using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SamsonErp.EntityFramework;

namespace SamsonErp.Migrator
{
    [DependsOn(typeof(SamsonErpDataModule))]
    public class SamsonErpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SamsonErpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
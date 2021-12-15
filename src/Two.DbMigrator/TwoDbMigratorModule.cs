using Two.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Two.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TwoEntityFrameworkCoreModule),
        typeof(TwoApplicationContractsModule)
        )]
    public class TwoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

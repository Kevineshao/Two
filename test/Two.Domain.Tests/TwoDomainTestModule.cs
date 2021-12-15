using Two.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Two
{
    [DependsOn(
        typeof(TwoEntityFrameworkCoreTestModule)
        )]
    public class TwoDomainTestModule : AbpModule
    {

    }
}
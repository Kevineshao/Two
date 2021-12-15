using Volo.Abp.Modularity;

namespace Two
{
    [DependsOn(
        typeof(TwoApplicationModule),
        typeof(TwoDomainTestModule)
        )]
    public class TwoApplicationTestModule : AbpModule
    {

    }
}
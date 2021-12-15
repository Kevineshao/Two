using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Two.Web
{
    [Dependency(ReplaceServices = true)]
    public class TwoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Two";
    }
}

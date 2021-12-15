using Two.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Two.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TwoController : AbpController
    {
        protected TwoController()
        {
            LocalizationResource = typeof(TwoResource);
        }
    }
}
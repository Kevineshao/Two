using Two.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Two.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TwoPageModel : AbpPageModel
    {
        protected TwoPageModel()
        {
            LocalizationResourceType = typeof(TwoResource);
        }
    }
}
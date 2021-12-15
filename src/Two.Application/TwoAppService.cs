using System;
using System.Collections.Generic;
using System.Text;
using Two.Localization;
using Volo.Abp.Application.Services;

namespace Two
{
    /* Inherit your application services from this class.
     */
    public abstract class TwoAppService : ApplicationService
    {
        protected TwoAppService()
        {
            LocalizationResource = typeof(TwoResource);
        }
    }
}

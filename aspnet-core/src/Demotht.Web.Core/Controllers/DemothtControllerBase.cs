using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Demotht.Controllers
{
    public abstract class DemothtControllerBase: AbpController
    {
        protected DemothtControllerBase()
        {
            LocalizationSourceName = DemothtConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

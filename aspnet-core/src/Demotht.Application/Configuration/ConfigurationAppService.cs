using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Demotht.Configuration.Dto;

namespace Demotht.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemothtAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

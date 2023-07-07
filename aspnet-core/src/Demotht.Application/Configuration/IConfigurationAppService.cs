using System.Threading.Tasks;
using Demotht.Configuration.Dto;

namespace Demotht.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

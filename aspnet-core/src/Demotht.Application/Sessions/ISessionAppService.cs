using System.Threading.Tasks;
using Abp.Application.Services;
using Demotht.Sessions.Dto;

namespace Demotht.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

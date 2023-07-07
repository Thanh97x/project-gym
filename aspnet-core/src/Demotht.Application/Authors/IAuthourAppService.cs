using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Demotht.Authors.Dto;
using Microsoft.AspNetCore.Builder;

namespace Demotht.Authors
{
    public interface IAuthourAppService:IApplicationService
    {
        IEnumerable<GetAuthorOutput> ListAll();
        Task Create(CreateAuthorInput input);
        void Update(UpdateAuthorInput Input);
        void Delete(DeleteAuthorInput Input);
        GetAuthorOutput GetAuthorById(GetAuthorInput input);
    }
}

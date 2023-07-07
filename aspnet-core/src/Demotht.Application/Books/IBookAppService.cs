using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Demotht.Books.Dto;
using Demotht.DbEntities;

namespace Demotht.Books.Dto
{
    public interface IBookAppService : IApplicationService
    {
        IEnumerable<GetBookOutput> ListAll();
        Task Create(CreateBookInput input);
        void Update(UpdateBookInput Input);
        void Delete(DeleteBookInput Input);
        GetBookOutput GetAuthorById(GetBookInput input);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Demotht.Books.Dto;
using Demotht.Categories.Dto;

namespace Demotht.Categories
{
    public interface ICategoryAppService:IApplicationService
    {
        IEnumerable<GetCategoryOutput> ListAll();
        Task Create(CreateCategoryInput input);
        void Update(UpdateCategoryInput input);
        void Delete(DeleteCategoryInput input);
        GetCategoryOutput GetAuthorById(GetCategoryInput input);
    }
}

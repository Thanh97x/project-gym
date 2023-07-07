using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Demotht.Models;

namespace Demotht.DbEntities
{
    public interface ICategoryManager:IDomainService
    {
        IEnumerable<Category> GetAllList();
        Category GetCategoryById(int id);
        Task<Category> Create(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}

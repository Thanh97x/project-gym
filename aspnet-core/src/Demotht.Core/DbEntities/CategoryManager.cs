using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Demotht.Models;

namespace Demotht.DbEntities
{
    public class CategoryManager:IDomainService,ICategoryManager
    {
        private readonly IRepository<Category> _repositoryCategory;
        public CategoryManager(IRepository<Category> repositoryCategory)
        {
            _repositoryCategory = repositoryCategory;
        }

        public async Task<Category> Create(Category entity)
        {
            var Category = _repositoryCategory.FirstOrDefault(x => x.Id == entity.Id);
            if (Category != null)
            {
                throw new UserFriendlyException("already exist");
            }
            else
            {
                return await _repositoryCategory.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var category = _repositoryCategory.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryCategory.InsertAsync(category);
            }
        }

        public IEnumerable<Category> GetAllList()
        {
            return _repositoryCategory.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _repositoryCategory.Get(id);
        }

        public void Update(Category entity)
        {
            _repositoryCategory.Update(entity);
        }
    }
}

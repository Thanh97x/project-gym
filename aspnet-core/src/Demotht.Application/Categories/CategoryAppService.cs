using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Demotht.Books.Dto;
using Demotht.Categories.Dto;
using Demotht.DbEntities;
using Demotht.Models;

namespace Demotht.Categories
{
    public class CategoryAppService:IApplicationService, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;
        public CategoryAppService(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task Create(CreateCategoryInput input)
        {
            Category output = _mapper.Map<CreateCategoryInput, Category>(input);
            await _categoryManager.Create(output);
        }

        public void Delete(DeleteCategoryInput input)
        {
            _categoryManager.Delete(input.Id);
        }

        public GetCategoryOutput GetAuthorById(GetCategoryInput input)
        {
            var getCategory = _categoryManager.GetCategoryById(input.Id);
            GetCategoryOutput output = _mapper.Map<Category, GetCategoryOutput>(getCategory);
            return output;
        }

        public IEnumerable<GetCategoryOutput> ListAll()
        {
            var getAll = _categoryManager.GetAllList().ToList();
            List<GetCategoryOutput> output = _mapper.Map<List<Category>, List<GetCategoryOutput>>(getAll);
            return output;
        }

        public void Update(UpdateCategoryInput input)
        {
            Category output = _mapper.Map<UpdateCategoryInput, Category>(input);
            _categoryManager.Update(output);
        }
    }
}

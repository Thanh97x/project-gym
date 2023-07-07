using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Demotht.Authors.Dto;
using Demotht.DbEntities;

namespace Demotht.Authors
{
    public class AuthorAppService:ApplicationService, IAuthourAppService
    {
        private readonly IAuthorManager _authorManager;
        private readonly IMapper _mapper;
        public AuthorAppService(IAuthorManager authorManager, IMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task Create(CreateAuthorInput input)
        {
            Author output = _mapper.Map<CreateAuthorInput, Author>(input);
            await _authorManager.Create(output);
        }

        public void Delete(DeleteAuthorInput input)
        {
            _authorManager.Delete(input.Id);
        }

        public GetAuthorOutput GetAuthorById(GetAuthorInput input)
        {
            var getAuthor = _authorManager.GetAuthorById(input.Id);
            GetAuthorOutput output = _mapper.Map<Author, GetAuthorOutput>(getAuthor);
            return output;
        }

        public IEnumerable<GetAuthorOutput> ListAll()
        {
            var getAll = _authorManager.GetAllList().ToList();
            List<GetAuthorOutput> output = _mapper.Map<List<Author>, List<GetAuthorOutput>>(getAll);
            return output;

        }

        public void Update(UpdateAuthorInput input)
        {
            Author output = _mapper.Map<UpdateAuthorInput, Author>(input);
            _authorManager.Update(output);
        }
    }

}

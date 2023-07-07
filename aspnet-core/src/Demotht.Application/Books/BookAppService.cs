using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Demotht.Authors.Dto;
using Demotht.Books.Dto;
using Demotht.DbEntities;

namespace Demotht.Books
{
    public class BookAppService:ApplicationService, IBookAppService
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;
        public BookAppService(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task Create(CreateBookInput input)
        {
            Book output = _mapper.Map<CreateBookInput, Book>(input);
            await _bookManager.Create(output);
        }

        public void Delete(DeleteBookInput input)
        {
            _bookManager.Delete(input.Id);
        }

        public GetBookOutput GetAuthorById(GetBookInput input)
        {
            var getBook = _bookManager.GetBookById(input.Id);
            GetBookOutput output = _mapper.Map<Book, GetBookOutput>(getBook);
            return output;
        }

        public IEnumerable<GetBookOutput> ListAll()
        {
            var getAll = _bookManager.GetAllList().ToList();
            List<GetBookOutput> output = _mapper.Map<List<Book>, List<GetBookOutput>>(getAll);
            return output;
        }

        public void Update(UpdateBookInput input)
        {
            Book output = _mapper.Map<UpdateBookInput, Book>(input);
            _bookManager.Update(output);
        }
    }
}

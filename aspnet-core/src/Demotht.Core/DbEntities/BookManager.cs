using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace Demotht.DbEntities
{
    public class BookManager:IDomainService,IBookManager
    {
        private readonly IRepository<Book> _repositoryBook;
        public BookManager(IRepository<Book> repositoryBook)
        {
            _repositoryBook = repositoryBook;
        }

        public async Task<Book> Create(Book entity)
        {
            var author = _repositoryBook.FirstOrDefault(x => x.Id == entity.Id);
            if (author != null)
            {
                throw new UserFriendlyException("already exist");
            }
            else
            {
                return await _repositoryBook.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var book = _repositoryBook.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryBook.InsertAsync(book);
            }
        }

        public IEnumerable<Book> GetAllList()
        {
            return _repositoryBook.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _repositoryBook.Get(id);

        }

        public void Update(Book entity)
        {
            _repositoryBook.Update(entity);
        }
    }
}

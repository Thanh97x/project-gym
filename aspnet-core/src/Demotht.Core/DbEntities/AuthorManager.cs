using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace Demotht.DbEntities
{
    public class AuthorManager:IDomainService, IAuthorManager
    {
        private readonly IRepository<Author> _repositoryAuthor;
        public AuthorManager(IRepository<Author> repositoryAuthor)
        {
            _repositoryAuthor = repositoryAuthor;
        }

        public async Task<Author> Create(Author entity)
        {
            var author = _repositoryAuthor.FirstOrDefault(x => x.Id == entity.Id);
            if(author != null)
            {
                throw new UserFriendlyException("already exist");
            }
            else
            {
                return await _repositoryAuthor.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var author = _repositoryAuthor.FirstOrDefault(x => x.Id == id);
            if (author == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryAuthor.InsertAsync(author);
            }
        }

        public IEnumerable<Author> GetAllList()
        {
            return _repositoryAuthor.GetAllIncluding(x => x.Books);
        }

        public Author GetAuthorById(int id)
        {
            return _repositoryAuthor.Get(id);
        }

        public void Update(Author entity)
        {
            _repositoryAuthor.Update(entity);
        }
    }
}

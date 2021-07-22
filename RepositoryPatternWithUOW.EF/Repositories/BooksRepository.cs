using RepositoryPatternWithUOW.Core.Interfaces;
using RepositoryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repositories
{
    public class BooksRepository : BaseRepository<Book>, IBooksRepository
    {
        private readonly ApplicationDbContext _context;

        public BooksRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Book> SpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
using RepositoryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Interfaces
{
    public interface IBooksRepository : IBaseRepository<Book>
    {
        IEnumerable<Book> SpecialMethod();
    }
}
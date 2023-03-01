using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get;}
    }
}

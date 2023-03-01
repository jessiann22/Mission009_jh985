using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}

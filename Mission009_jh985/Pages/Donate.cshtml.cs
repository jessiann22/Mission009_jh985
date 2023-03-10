using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission009_jh985.Models;

namespace Mission009_jh985.Pages
{
    public class DonateModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }


        public DonateModel (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(int bookId)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket = new Basket();

            basket.AddItem(b, 1);

            return RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission009_jh985.Models;
using Mission009_jh985.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Controllers
{
    public class HomeController : Controller
    {

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        //private BookstoreContext context { get; set; }
        //public HomeController(BookstoreContext temp) => context = temp;

        public IActionResult Index(string projectType, int pageNum = 1)
        {
            int pageSize = 10;


            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where( b  => b.Category == Category || b.Category == null) //HELPs
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                Pageinfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

            return View(x);
        }
        /*
            //var home = context.Books.ToList();
            var home = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum-1) * pageSize)
                .Take(pageSize);
            return View(home);
        } */
    }
}
/*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
 */
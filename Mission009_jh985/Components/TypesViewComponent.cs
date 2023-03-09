﻿using Microsoft.AspNetCore.Mvc;
using Mission009_jh985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public TypesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.Selectedtype = RouteData?.Values["Category"];

            var types = repo.Books
                   .Select(x => x.Category)
                   .Distinct()
                   .OrderBy(x => x);

            return View(types);
        }
    }
}

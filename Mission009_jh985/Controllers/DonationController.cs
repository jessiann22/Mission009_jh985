﻿using Microsoft.AspNetCore.Mvc;
using Mission009_jh985.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Donation());
        }
    }
}
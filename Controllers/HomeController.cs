﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SakilaMVC.Models;

namespace SakilaMVC.Controllers
{
    public class HomeController : Controller
    {
        private static short LENGTH_THRES = 120;
        private SakilaContext _context;
    
        public HomeController(SakilaContext context)
        {
            _context = context;
        }
    
        [HttpGet("")]
        public IActionResult Index()
        {
            IEnumerable<Film> model = _context.film.Where(f => f.rating == "NC-17" && f.length >= LENGTH_THRES);
            return View(model);
            // Other code
        }
        [HttpGet("cities")]
        public IActionResult Cities()
        {
            IEnumerable<City> model = _context.city.Where(c => c.country_id == 103);
            return View(model);
            // Other code
        }
        [HttpGet("staff")]
        public IActionResult Staff()
        {
            IEnumerable<Staff> model = _context.staff.Where(s => s.staff_id > 1 && s.staff_id < 20).ToList();
            return View(model);
            // Other code
        }
        [HttpGet("address")]
        public IActionResult Address()
        {
            IEnumerable<Address> model = _context.address.Where(a => a.address_id > 10 && a.address_id < 50);
            return View(model);
            // Other code
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

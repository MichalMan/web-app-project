using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeBnB.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeBnB.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeBnBContext _context;

        public HomeController(HomeBnBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
            //var apartments = from m in _context.Apartment select m;
            //if (!String.IsNullOrEmpty(RenterName))
            // {
            //   apartments = apartments.Where(s => s.LandLord.Name.Contains(RenterName));
            // }

            //return View(await apartments.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApartmentID,Address,Owner,Price,NumberOfRooms,Renovated,Description")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(apartment);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

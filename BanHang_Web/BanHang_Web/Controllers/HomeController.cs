using BanHang_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BanHang_Web.Models.DB;

namespace BanHang_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PL_BanHangContext _context;

        public HomeController(PL_BanHangContext context)
        {
            _context = context;
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

        public IActionResult Test()
        {
            List<Product> products = _context.Products.ToList();
            return Ok(products);
        }
    }
}

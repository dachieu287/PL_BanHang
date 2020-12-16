using BanHang_Web.Models.DB;
using BanHang_Web.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using BanHang_Web.Models.DB;

namespace BanHang_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PL_BanHangContext _context;

        public HomeController(PL_BanHangContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IndexViewModel model = new IndexViewModel
            {
                Catalogs = await _context.Catalogs
                    .Include(i => i.Products)
                    .ToListAsync(),
                Combos = await _context.Combos.ToListAsync(),
            };
            return View(model);
        }

        public IActionResult Test()
        {
            return Ok(_context.Products.ToList());
        }
    }
}

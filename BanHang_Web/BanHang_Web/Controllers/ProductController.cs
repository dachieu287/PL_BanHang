using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHang_Web.Models.DB;
using BanHang_Web.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace BanHang_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly PL_BanHangContext _context;

        public ProductController(PL_BanHangContext context)
        {
            _context = context;
        }
        public IActionResult Index(string type, string id)
        {
            if (String.IsNullOrEmpty(type) || String.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            ProductViewModel model = new ProductViewModel();
            if (type.Equals("product"))
            {
                Product product = _context.Products
                    .Include(i => i.Catalog)
                    .FirstOrDefault(p => p.Id.Equals(id));
                model.ID = product.Id;
                model.IsProduct = true;
                model.Catalog = product.Catalog.Name;
                model.Name = product.Name;
                model.Image = product.Image;
                model.Price = product.Price;
            }
            else if (type.Equals("combo"))
            {
                Combo combo = _context.Combos
                    .FirstOrDefault(c => c.Id.Equals(id));
                model.ID = combo.Id;
                model.IsProduct = false;
                model.Catalog = "Combo";
                model.Name = combo.Name;
                model.Image = combo.Image;
                model.PrevPrice = (decimal)combo.PrevPrice;
                model.Price = combo.Price;
            }
            return View(model);
        }
    }
}

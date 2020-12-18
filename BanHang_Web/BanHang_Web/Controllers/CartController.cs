using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHang_Web.Extensions;
using BanHang_Web.Models.ViewModel;
using BanHang_Web.Models.DB;
using System.Text.Json;

namespace BanHang_Web.Controllers
{
    public class CartController : Controller
    {
        private readonly PL_BanHangContext _context;

        public CartController(PL_BanHangContext context)
        {
            _context = context;
        } 

        public IActionResult Index()
        {
            List<CartViewModel> models = HttpContext.Session.Get<List<CartViewModel>>("Cart");
            if (models == default)
            {
                models = new List<CartViewModel>();
            }
            else
            {
                foreach (CartViewModel model in models)
                {
                    if (model.IsProduct)
                    {
                        Product product = _context.Products.FirstOrDefault(p => p.Id.Equals(model.Id));
                        model.Name = product.Name;
                        model.Image = product.Image;
                    }
                    else
                    {
                        Combo combo = _context.Combos.FirstOrDefault(c => c.Id.Equals(model.Id));
                        model.Name = combo.Name;
                        model.Image = combo.Image;
                    }
                }
            }

            return View(models);
        }

        [HttpPost]
        public string AjaxAdd(string id, bool isProduct = true, int quantity = 1)
        {
            List<CartViewModel> carts = HttpContext.Session.Get<List<CartViewModel>>("Cart");
            if (carts == default)
            {
                carts = new List<CartViewModel>();
            }

            CartViewModel cart = carts.FirstOrDefault(c => c.IsProduct == isProduct && c.Id.Equals(id));
            if (cart != null)
            {
                cart.Quantity++;
            }
            else
            {
                cart = new CartViewModel();
                if (isProduct)
                {
                    Product product = _context.Products.FirstOrDefault(p => p.Id.Equals(id));
                    cart.Id = id;
                    cart.Price = product.Price;
                    cart.Quantity = quantity;
                    cart.IsProduct = true;
                }
                else
                {
                    Combo combo = _context.Combos.FirstOrDefault(c => c.Id.Equals(id));
                    cart.Id = id;
                    cart.Price = combo.Price;
                    cart.Quantity = quantity;
                    cart.IsProduct = false;
                }
                carts.Add(cart);
            }
          
            HttpContext.Session.Set("Cart", carts);
            return JsonSerializer.Serialize(carts);
        }

        public IActionResult Add(string id, bool isProduct, int quantity)
        {
            List<CartViewModel> carts = HttpContext.Session.Get<List<CartViewModel>>("Cart");
            if (carts == default)
            {
                carts = new List<CartViewModel>();
            }

            CartViewModel cart = carts.FirstOrDefault(c => c.IsProduct == isProduct && c.Id.Equals(id));
            if (cart != null)
            {
                cart.Quantity = quantity;
            }
            else
            {
                cart = new CartViewModel();
                if (isProduct)
                {
                    Product product = _context.Products.FirstOrDefault(p => p.Id.Equals(id));
                    cart.Id = id;
                    cart.Price = product.Price;
                    cart.Quantity = quantity;
                    cart.IsProduct = true;
                }
                else
                {
                    Combo combo = _context.Combos.FirstOrDefault(c => c.Id.Equals(id));
                    cart.Id = id;
                    cart.Price = combo.Price;
                    cart.Quantity = quantity;
                    cart.IsProduct = false;
                }
                carts.Add(cart);
            }
            HttpContext.Session.Set("Cart", carts);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(string id, bool isProduct)
        {
            List<CartViewModel> carts = HttpContext.Session.Get<List<CartViewModel>>("Cart");
            int index = carts.FindIndex(m => m.IsProduct == isProduct && m.Id.Equals(id));
            carts.RemoveAt(index);
            if (carts.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.Set("Cart", carts);
            }
           
            return RedirectToAction("Index");
        }

        public IActionResult RemoveAll()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Index", "Home");
        }

        public string Checkout()
        {
            List<CartViewModel> carts = HttpContext.Session.Get<List<CartViewModel>>("Cart");
            if (carts == default)
            {
                return "nothing";
            }

            Account account = HttpContext.Session.Get<Account>("Account");
            if (account == default)
            {
                return "nologin";
            }

            List<BillDetail> billDetails = new List<BillDetail>();
            decimal total = 0;
            foreach (CartViewModel cart in carts)
            {
                BillDetail billDetail = new BillDetail
                {
                    ProductId = cart.IsProduct ? cart.Id : null,
                    ComboId = cart.IsProduct ? null : cart.Id,
                    Price = cart.Price,
                    Quantity = cart.Quantity,
                };
                total += cart.Price * cart.Quantity;
                billDetails.Add(billDetail);
            }

            Bill bill = new Bill
            {
                Name = account.Name,
                Address = account.Address,
                Phone = account.Phone,
                Datetime = DateTime.Now,
                Status = 1,
                Total  = total,
                BillDetails = billDetails,
            };
            _context.Bills.Add(bill);
            _context.SaveChanges();
            HttpContext.Session.Remove("Cart");

            return "success";  
        }
    }
}

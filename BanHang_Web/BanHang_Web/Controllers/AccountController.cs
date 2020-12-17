using BanHang_Web.Models.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHang_Web.Extensions;

namespace BanHang_Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly PL_BanHangContext _context;

        public AccountController(PL_BanHangContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string name, bool gender, string email, string phone, string address)
        {
            if (_context.Accounts.Any(m => m.Username.Equals(username)))
            {
                return View("UsernameExist");
            }

            Account account = new Account
            {
                Username = username,
                Password = password,
                Name = name,
                Gender = gender,
                Email = email,
                Phone = phone,
                Address = address,
                Active = true,
                Role = "Customer",
                BirthDay = DateTime.Now
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();

            HttpContext.Session.Set("Account", account);

            return View("Success");
        }
    }
}

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
        public string Register(string username, string password, string name, bool gender, string email, string phone, string address)
        {
            if (_context.Accounts.Any(m => m.Username.Equals(username)))
            {
                return "UsernameExist";
                //return View("UsernameExist");
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

            return "Success";
            //return View("Success");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Account");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public bool Login(string username, string password)
        {
            Account account = _context.Accounts.FirstOrDefault(a => a.Username.Equals(username) && a.Password.Equals(password));
            if (account == null)
            {
                return false;
            }
            HttpContext.Session.Set("Account", account);
            return true;
        }
    }
}

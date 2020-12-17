using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang_Web.Models.ViewModel
{
    public class CartViewModel
    {
        public string Id { get; set; }
        public bool IsProduct { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
    }
}

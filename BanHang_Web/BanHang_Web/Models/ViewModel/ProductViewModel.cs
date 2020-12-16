using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang_Web.Models.ViewModel
{
    public class ProductViewModel
    {
        public string ID { get; set; }
        public bool IsProduct { get; set; }
        public string Catalog { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public decimal PrevPrice { get; set; }
        public decimal Price { get; set; }
    }
}

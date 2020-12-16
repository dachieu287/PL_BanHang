using BanHang_Web.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang_Web.Models.ViewModel
{
    public class IndexViewModel
    {
        public List<Catalog> Catalogs { get; set; }
        public List<Combo> Combos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class ComboDetail
    {
        public string ComboId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Combo Combo { get; set; }
        public virtual Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class BillDetail
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public string ProductId { get; set; }
        public string ComboId { get; set; }
        public int PriceId { get; set; }
        public int Quantity { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual Price Price { get; set; }
        public virtual Product Product { get; set; }
    }
}

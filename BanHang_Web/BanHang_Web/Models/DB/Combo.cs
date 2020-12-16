using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class Combo
    {
        public Combo()
        {
            BillDetails = new HashSet<BillDetail>();
            ComboDetails = new HashSet<ComboDetail>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public decimal? PrevPrice { get; set; }
        public int? Discount { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<ComboDetail> ComboDetails { get; set; }
    }
}

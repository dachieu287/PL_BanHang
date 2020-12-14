using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class Price
    {
        public Price()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ComboId { get; set; }
        public DateTime FromDatetime { get; set; }
        public DateTime? ToDatetime { get; set; }
        public decimal? PrevPrice { get; set; }
        public int? Discount { get; set; }
        public decimal Price1 { get; set; }

        public virtual Combo Combo { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}

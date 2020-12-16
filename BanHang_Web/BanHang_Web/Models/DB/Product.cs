using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class Product
    {
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
            ComboDetails = new HashSet<ComboDetail>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string CatalogId { get; set; }

        public virtual Catalog Catalog { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<ComboDetail> ComboDetails { get; set; }
    }
}

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
            Prices = new HashSet<Price>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<ComboDetail> ComboDetails { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}

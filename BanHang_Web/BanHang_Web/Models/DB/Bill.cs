using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Datetime { get; set; }
        public decimal Total { get; set; }
        public int Status { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}

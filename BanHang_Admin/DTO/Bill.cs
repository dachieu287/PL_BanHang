using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public int ID { get; set; }
        public Account Account { get; set; }
        public DateTime Datetime { get; set; }
        public decimal Total { get; set; }
        public BillStatus Status { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }

    public enum BillStatus
    {
        Tại_cửa_hàng = 0,
    }
}

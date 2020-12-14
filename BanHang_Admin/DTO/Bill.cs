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
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Datetime { get; set; }
        public decimal Total { get; set; }
        public BillStatus Status { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }

    public enum BillStatus
    {
        Unprocessed = 1,
        Processing = 2,
        Shipping = 3,
        Done = 4,
        Cancel = 5
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDetail
    {
        public int ID { get; set; }
        public Bill Bill { get; set; }
        public Product Product { get; set; }
        public Combo Combo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Price
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public Combo Combo { get; set; }
        public decimal? PrevPrice { get; set; }
        public int? Discount { get; set; }
        public decimal? Pricez { get; set; }
        public DateTime FromDatetime { get; set; }
        public DateTime? ToDatetime { get; set; }
    }
}

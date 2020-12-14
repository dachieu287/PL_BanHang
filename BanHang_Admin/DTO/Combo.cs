using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Combo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public decimal PrevPrice { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComboDetail
    {
        public Combo Combo { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

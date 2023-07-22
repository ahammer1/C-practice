using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reductio___Absurdum
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int ProductTypeId { get; set; }
    }
}

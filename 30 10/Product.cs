using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} • Amount: {Amount} • Country: {Country} • Price: {Price}";
        }
    }
}

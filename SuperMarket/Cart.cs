using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal class Cart
    {
        public Item[] items { get; set; }

        public Cart() { } 
        public Cart(Item[] Store) { this.items = Store; }
        ~ Cart() {  }    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    internal class Item
    {
        internal string Id { set; get; }
        internal string Name { set; get; }
        internal int Quantity {set; get; }
        internal double Price { set; get; }
        
        
        internal Item() { }

        internal Item(string id , string name , double price) {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        }

        internal Item(string id, string name,int quantity ,double price)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        ~ Item() { }    
    }
}

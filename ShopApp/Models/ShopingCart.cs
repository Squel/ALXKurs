using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class ShopingCart
    {
        public Products Products { get; set; }
        public int NoOfProducts {  get; set; } 
        public ShopingCart(Products products, int numberItems)
        {
            Products = products;
            NoOfProducts = numberItems;
        }

        public decimal GetPrice()
        {
            return Products.Price * NoOfProducts;
        }
    }
}

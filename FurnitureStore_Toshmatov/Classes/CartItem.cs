using System;

namespace FurnitureStore_Toshmatov.Classes
{
    public class CartItem
    {
        public Item Product { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice => Product.Price * Quantity;

        public CartItem(Item product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
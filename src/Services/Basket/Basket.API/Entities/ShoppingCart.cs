﻿using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
           
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public ShoppingCart(string userName, List<ShoppingCartItem> ıtems)
        {
            UserName = userName;
            Items = ıtems;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }
    }
}

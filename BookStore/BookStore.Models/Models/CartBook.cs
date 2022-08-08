﻿using BookStore.Models.ViewModels;
using System.Collections.Generic;

namespace BookStore.Models.Models
{
    public class CartBook
    {
        public CartBook() { }

        public CartBook(Cart cart)
        {
            Id = cart.Id;
            UserId = cart.Userid;
            BookId = cart.Bookid;
            Quantity = cart.Quantity;
            BookName = cart.Book.Name;
            Price = cart.Book.Price;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
    }
}

﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.BLL.Abstract
{
    public interface ICartService
    {


        void InitializeCart(string UserId);

        Cart GetCartByUserId(string userId);
        void AddToCart(string userId, int productId, int quantity);
        void DeleteFromCart(string userId, int productId);
        void ClearCart(string cartId);
    }
}
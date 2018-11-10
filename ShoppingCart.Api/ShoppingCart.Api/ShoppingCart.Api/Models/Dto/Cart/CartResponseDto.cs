﻿using System;
using System.Collections.Generic;
using ShoppingCart.Api.Models.Dto.Common;

namespace ShoppingCart.Api.Models.Dto.Cart
{
    public class CartResponseDto : Resource
    {
        public Guid Id { get; set; }

        public List<CartItemResponseDto> CartItems { get; set; } = new List<CartItemResponseDto>();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using product.resource;

namespace product.Models
{
    public static class ProductExtension
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto
            {
                id = product.Id,
                name = product.Name,
                price = product.Price
            };
        }
    }
}
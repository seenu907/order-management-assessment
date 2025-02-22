﻿using System.Diagnostics;
using System.Xml.Linq;
using System;
using System.Data.Common;

namespace ProductService.Core.Models;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public int CategoryId { get; set; }

    public int SellerId { get; set; }
}


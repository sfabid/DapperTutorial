﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperTutorial.Api.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Active { get; set; }
    }
}
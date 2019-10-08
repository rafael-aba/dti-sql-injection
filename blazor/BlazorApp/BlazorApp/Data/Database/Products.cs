using System;
using System.Collections.Generic;

namespace BlazorApp.Data.Database
{
    public partial class Products
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
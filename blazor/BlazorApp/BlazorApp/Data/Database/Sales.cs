using System;
using System.Collections.Generic;

namespace BlazorApp.Data.Database
{
    public partial class Sales
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int UserIdSeller { get; set; }
        public int UserIdBuyer { get; set; }
        public decimal Price { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
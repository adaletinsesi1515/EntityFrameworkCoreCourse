using System;
using System.Collections.Generic;

namespace UdemyEfCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }

        public List<SaleHistory> saleHistory { get; set; }
        public ProductDetail ProductDetail { get; set; }

        public List<ProductCategory> productCategories { get; set; }

    }
}

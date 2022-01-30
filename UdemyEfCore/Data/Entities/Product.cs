using System;

namespace UdemyEfCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
